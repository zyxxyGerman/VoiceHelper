using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace helperform.Commands
{
    class OpenYandexCommand :ICommand
    {
        public string Command { get; set; } = "Открой яндекс";

        public void Execute()
        {
            Process.Start("http://www.yandex.com/");
        }
    }
}
