using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoSys
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
             fp = new frmPrincipal();
             Application.Run(fp);
            //Application.Run(new frmLogin());
            Application.Run(new frmSplash());
            //Application.Run(new frmClientes());
            // Application.Run(new frmCadastroClientes());


        }
        public static int idtransferido;
        public static frmPrincipal fp;
    }
}
