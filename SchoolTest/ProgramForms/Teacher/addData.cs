﻿using System;
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
    public partial class addData : Form
    {
        public addData()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form ifrm = new teacherHome();
            ifrm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ifrm = new add_subject();
            ifrm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form ifrm = new add_user();
            ifrm.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form ifrm = new add_class();
            ifrm.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form ifrm = new add_theme();
            ifrm.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form ifrm = new add_literature();
            ifrm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ifrm = new add_question();
            ifrm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new add_test();
            ifrm.Show();
            this.Close();
        }
    }
}
