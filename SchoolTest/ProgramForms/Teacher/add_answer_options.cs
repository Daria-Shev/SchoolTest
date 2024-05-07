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
    public partial class add_answer_options : Form
    {
        object data;
        string id;
        public add_answer_options(object data)
        {
            InitializeComponent();
            this.data = data;
        }
    }
}
