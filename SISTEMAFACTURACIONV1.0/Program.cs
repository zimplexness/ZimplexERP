using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErpGestion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            LoginFrm loginfrm = new LoginFrm();
            loginfrm.ShowDialog();




            if (loginfrm.DialogResult == DialogResult.OK)
            {



                Application.Run(new ZimplexHome());
            } 




        }
    }
}
