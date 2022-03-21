using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLProjectForms1
{
    //public const int userID;
   // public string userName;
    static class Program
    {
        public static int FahrenheitToCelsius()
        {
            int celsius=0;

            return celsius;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Home());
        }
        
    }
}
