using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HelperSpeechRecognizer.Commands
{
    class OpenYouTubeCommand : ICommand
    {
        public string Command { get; set; } = "Открой ютуб";

        public void Execute()
        {
            Process.Start("http://www.youtube.com/");
        }
    }
}
