using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperSpeechRecognizer.Commands
{
    public interface ICommand
    {
        string Command { get; set; }
        void Execute();
    }
}
