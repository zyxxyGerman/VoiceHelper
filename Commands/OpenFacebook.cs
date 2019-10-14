using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helperform.Commands
{
    class OpenFacebook : ICommand

{
    public string Command { get; set; } = "Открой фейсбук";

    public void Execute()
    {
        Process.Start("http://www.facebook.com/");
    }
}
}
