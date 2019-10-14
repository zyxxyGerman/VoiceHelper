using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace helperform.Commands
{
    class CloseProgramm : ICommand
    {
        public string Command { get; set; } = "Закройся";

        public void Execute()
        {
            Process.Start("Application.Exit();");
        }
    }
}

