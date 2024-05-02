using Newtonsoft.Json;
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
            var data = new { id = 0, subject_name = "", class_number = "" };
            Form ifrm = new add_subject_show(data);
            ifrm.ShowDialog();
            //this.Close();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = data_dedicated();
            Form ifrm = new add_subject_show(data);
            ifrm.ShowDialog();
        }
        private object data_dedicated()
        {
            int id= 0;
            string subject_name="";
            string class_number ="";
            // Проверяем, есть ли выделенные ряды
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Получаем первый выбранный ряд (можно добавить логику для обработки нескольких выбранных рядов)
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Получаем значения из нужных ячеек в выбранном ряду
                 id = int.Parse(selectedRow.Cells["subject_id"].Value.ToString());
                 subject_name = selectedRow.Cells["subject_name"].Value.ToString();
                 class_number = selectedRow.Cells["subject_class_number"].Value.ToString();
                // Продолжайте для других столбцов по аналогии...

                // Передаем значения в другую форму или обрабатываем их здесь
            }
            var data = new { id, subject_name, class_number };
            return data;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Table();
        }
    }
}
