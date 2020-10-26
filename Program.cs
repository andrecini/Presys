using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cálculo_De_Incertezas
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CERTIFICADO());
        }
    }
}
