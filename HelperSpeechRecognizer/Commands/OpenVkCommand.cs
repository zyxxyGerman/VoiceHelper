using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HelperSpeechRecognizer.Commands
{
    class OpenVkCommand :ICommand
    {
        public string Command { get; set; } = "Открой вк";

        public void Execute()
        {
            Process.Start("https://vk.com/");
        }
    }
}
