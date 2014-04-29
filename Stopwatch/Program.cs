using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TaskStopwatch
{
    static class Program
    {
        public static MainTaskScreen mainForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new MainTaskScreen();
            Application.Run(mainForm);
        }
    }
}
