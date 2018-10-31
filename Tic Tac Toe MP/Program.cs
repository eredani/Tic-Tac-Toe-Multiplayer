using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_MP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        ///  
        static Mutex mutex = new Mutex(true, "{8F6F0AC4-B9A1-45fd-A8CF-72F04E6DDE8F}");
        [STAThread]
        static void Main()
        {
            if (!mutex.WaitOne(TimeSpan.Zero, true))
            {
                MessageBox.Show("You cannot open two games on the same PC.");
                //Environment.Exit(0);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Login());
            }
        }
    }
}
