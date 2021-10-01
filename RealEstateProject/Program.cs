using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateProject
{
     static class Program
    {
        public static bool isLogged = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RealEstateManagmentApplication());

            /*            Application.Run(new Auth());

                        if (!isLogged)
                            Application.Exit();
                        else
                        {
                            Application.Run(new RealEstateManagmentApplication());
                        }*/
        }
    }
}
