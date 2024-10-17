using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hôtelliere
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (GlobalProcedure.fncConnectToDatabase())
            {
                Application.Run(new Hôtelliere_StartUp());
                //Application.Run(new Hôtelliere_Default());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
