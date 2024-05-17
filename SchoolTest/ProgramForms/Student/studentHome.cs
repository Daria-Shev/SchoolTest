using SchoolTest.ProgramForms.Statistics;
using SchoolTest.ProgramForms.Teacher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolTest.ProgramForms.Student
{
    public partial class studentHome : Form
    {
        public studentHome()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ApiClass api=new ApiClass();

            api.exit();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form ifrm = new menuTest();
            ifrm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new Statistics_student();
            ifrm.Show();
            this.Close();
        }
    }
}
