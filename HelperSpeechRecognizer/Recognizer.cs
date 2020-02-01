using Microsoft.Speech.Recognition;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperSpeechRecognizer
{
    public class Recognizer
    {
        public delegate void RecognizeHandler(string message);

        public event RecognizeHandler Recognized;
        public void Start()
        {
            SpeechRecognitionEngine sre = new SpeechRecognitionEngine(CultureInfo.GetCultureInfo("ru-ru"));// To do сделать распознование на основе языка винды
            sre.SetInputToDefaultAudioDevice();
            //var dictionaryRu = File.ReadAllText(@"Dictionary/ru-ru.txt", Encoding.UTF8).Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);

            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(new Choices(CommandList.Commands.Select(c => c.Command).ToArray()));
            //gb.Append(new Choices(dictionaryRu));
            sre.LoadGrammar(new Grammar(gb));

            sre.RecognizeAsync(RecognizeMode.Multiple);

        }


        private void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Confidence > 0.7)
            {
                Recognized?.Invoke(e.Result.Text);
                var command = CommandList.Commands.Where(c => c.Command.Equals(e.Result.Text)).FirstOrDefault();
                if (command != null)
                {
                    command.Execute();
                }
            }
        }
    }
}
