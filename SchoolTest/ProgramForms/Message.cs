using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolTest.ProgramForms
{
    public static  class Message
    {
        public static void MessageInfo(string info) {
            MessageBox.Show(
            info, 
            "Повідомлення", 
            MessageBoxButtons.OK, 
            MessageBoxIcon.Information, 
            MessageBoxDefaultButton.Button1, 
            MessageBoxOptions.DefaultDesktopOnly);
        }


    }
}
