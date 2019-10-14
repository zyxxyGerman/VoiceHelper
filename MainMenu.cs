using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Speech.Recognition;

namespace helperform
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }


        private void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Confidence > 0.7)
            {
                label1.Text = e.Result.Text;
                var command = Program.Commands.Where(c => c.Command.Equals(e.Result.Text)).FirstOrDefault();
                if(command != null)
                {
                    command.Execute();
                }
            }
            if(e.Result.Text == "Закройся")
            {
                Application.Exit();
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            SpeechRecognitionEngine sre = new SpeechRecognitionEngine(CultureInfo.GetCultureInfo("ru-ru"));
            sre.SetInputToDefaultAudioDevice();

            sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);


            Choices words = new Choices();
            words.Add(new string[] { "один", "два", "три", "четыре", "пять", "шесть" , "Закройся", "Открой гугл", "Открой яндекс", "Открой ютуб", "Открой фейсбук", "Открой школьный сайт", "Открой школьные курсы", "найди", "шесть найди" });
            GrammarBuilder gb = new GrammarBuilder();
            // gb.Culture = ci;
            gb.Append(words);

            Grammar g = new Grammar(gb);
            sre.LoadGrammar(g);

            sre.RecognizeAsync(RecognizeMode.Multiple);

        }
        private void Search(object sender, EventArgs e)
        {
            Process.Start("http://google.com/search?q=");
        }
    }
}
