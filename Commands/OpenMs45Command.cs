using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace helperform.Commands
{
    class OpenMs45Command :ICommand
    {
        public string Command { get; set; } = "Открой школьный сайт";

        public void Execute()
        {
            Process.Start("https://ms45.edu.ru/");
        }
    }
}
