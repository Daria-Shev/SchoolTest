using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolTest.ProgramForms.Statistics;


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

        private void button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new StatisticsTeacher();
            ifrm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ifrm = new addData();
            ifrm.Show();
            this.Close();
        }

        private void teacherHome_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(@"Інструкція_вчителю.docx");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
