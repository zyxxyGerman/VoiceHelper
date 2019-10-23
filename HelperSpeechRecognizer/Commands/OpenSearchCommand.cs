using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HelperSpeechRecognizer.Commands
{
    class OpenSearchCommand : ICommand
    {
        public string Command { get; set; } = "найди";

        public void Execute()
        {
            Process.Start("http://google.com/search?q=");
        }
    }
}
