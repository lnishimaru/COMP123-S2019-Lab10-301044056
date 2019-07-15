using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_301044056
{
    static class Program
    {
        public static EndForm endForm;
        public static MainForm mainForm;
        public static StartForm startForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            endForm = new EndForm();
            mainForm = new MainForm();
            startForm = new StartForm();
            Application.Run(Program.startForm);
        }
    }
}
