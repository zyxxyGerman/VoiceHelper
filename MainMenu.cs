using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelperSpeechRecognizer;
using Microsoft.Speech.Recognition;

namespace helperform
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }



        private void Form1_Shown(object sender, EventArgs e)
        {
            var recognizer = new Recognizer();
            recognizer.Recognized += PrintText;
            recognizer.Start();

        }

        private void PrintText(string message)
        {
            label1.Text = message;
        }
    }
}
