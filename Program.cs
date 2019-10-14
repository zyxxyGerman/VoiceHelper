using helperform.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helperform
{
    public static class Program
    {
        public static List<ICommand> Commands = new List<ICommand>
            {
                new OpenGoogleCommand()
            };

        [STAThread]
        static void Main(String[] agrs)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
