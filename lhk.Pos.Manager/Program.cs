using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using lhk.POS.Core;
using lhk.POS.Presentation.Views;
using Nop.Core.Infrastructure;
using PosSystem.Depency;

namespace PosSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Singleton<PosEngine>.Instance = new PosEngine();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new InputProductTest());

            var frmLogin = new LoginView(Constants.UserRole.Supervisor);
            if (frmLogin.ShowDialog().Equals(DialogResult.OK))
            {
                Application.Run(new Main());
            }
            else
            {
                Application.Exit();
            }
        }

    }
}
