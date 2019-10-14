using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace helperform.Commands
{
    class OpenCoursesCommand : ICommand
    {
        public string Command { get; set; } = "Открой школьные курсы";

        public void Execute()
        {
            Process.Start("https://ms45.edu.ru/courses");
        }
    }
}
