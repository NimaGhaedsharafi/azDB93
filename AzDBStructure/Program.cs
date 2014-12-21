using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzDBStructure
{
    static class Program
    {

        public static string access = "a";
        public static string username = "nghaedsharafi";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLogin());
            
            if (access.CompareTo("a") == 0)
            {
                Application.Run(new table());
            }
            else if (access.CompareTo("n") == 0)
            {
                Application.Run(new frmUserMainPage());
            }
        }
    }
}
