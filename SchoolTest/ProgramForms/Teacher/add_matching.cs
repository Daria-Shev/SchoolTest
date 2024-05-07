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
    public partial class add_matching : Form
    {
        object data;
        string id;
        public add_matching(object data)
        {
            InitializeComponent();
            this.data = data;
        }

    }
}
