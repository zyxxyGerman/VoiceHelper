using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperSpeechRecognizer.Commands
{
    class OpenGoogleCommand : ICommand

    {
        public string Command { get; set; } = "Открой гугл";

        public void Execute()
        {
            Process.Start("http://www.google.com/");
        }
    }
}
