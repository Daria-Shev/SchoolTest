using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolTest.ProgramForms.Teacher
{
    public partial class teacherHome : Form
    {
        public teacherHome()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form ifrm = new addData();      
            ifrm.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ApiClass api = new ApiClass();

            api.exit();
            this.Close();
        }
    }
}
