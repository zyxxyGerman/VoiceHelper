using HelperSpeechRecognizer.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelperSpeechRecognizer
{
    public static class CommandList
    {
        public static List<ICommand> Commands = new List<ICommand>
            {
             new OpenGoogleCommand()
            ,new OpenFacebookCommand()
            ,new OpenYouTubeCommand()
            ,new OpenYandexCommand()
            ,new OpenMs45Command()
            ,new OpenCoursesCommand()
            ,new OpenSearchCommand()
            ,new OpenVkCommand()
            ,new CloseProgramm()
            };
    }
}
