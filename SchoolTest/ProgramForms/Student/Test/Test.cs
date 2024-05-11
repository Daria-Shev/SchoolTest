using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolTest.ProgramForms.Student.Test
{
    public partial class Test : Form
    {
 
        string test_id;
        string test_type;

        public Test(string test_id, string test_type)
        {
            InitializeComponent();
            this.test_id = test_id;
            this.test_type = test_type;
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }
    }
}
