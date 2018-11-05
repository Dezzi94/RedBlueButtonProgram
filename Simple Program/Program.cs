using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Program
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application. Little C# App.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmButtonsAndMessageboxes());
        }
    }
}
