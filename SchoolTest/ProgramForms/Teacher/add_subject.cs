﻿using Newtonsoft.Json;
using SchoolTest.Helpers;
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
    public partial class add_subject : Form
    {
        public add_subject()
        {
            InitializeComponent();

        }
        //даные в таблицу перенос  DataSource
        private void Table()
        {
            ApiClass authApi = new ApiClass();

            authApi.path = "subject_table";
            authApi.uriCreate();

            var Stream = authApi.ServerAuthorization();

            var info = JsonHelpers.ReadFromJsonStream<string>(Stream);
            dataGridView1.DataSource = JsonConvert.DeserializeObject(info, typeof(DataTable)) as DataTable;
        }

        private void add_subject_Load(object sender, EventArgs e)
        {
            Table();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form ifrm = new addData();
            ifrm.Show();
            this.Close();
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form ifrm = new add_subject_show();
            ifrm.ShowDialog();
            //this.Close();
        }
    }
}
