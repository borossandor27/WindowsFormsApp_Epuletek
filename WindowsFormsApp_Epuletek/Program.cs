using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Epuletek
{
    static class Program
    {
        public static Form_Nyito form_Nyito = null;
        public static Form_Csaladihaz form_csaladihaz = null;
        public static Form_Tombhaz form_Tombhaz = null;
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form_Nyito = new Form_Nyito();
            form_csaladihaz = new Form_Csaladihaz();
            form_Tombhaz = new Form_Tombhaz();

            Application.Run(form_Nyito);
        }
    }
}
