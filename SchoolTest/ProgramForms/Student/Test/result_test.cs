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

namespace SchoolTest.ProgramForms.Student.Test
{
    public partial class result_test : Form
    {
        string test_id;
        int test_attempt;
        public result_test(string test_id, int test_attempt)
        {
            InitializeComponent();
            this.test_id = test_id;
            this.test_attempt = test_attempt;
        }

        private void result_test_Load(object sender, EventArgs e)
        {
            Table();

        }
        public void Table()
        {
            ApiClass authApi = new ApiClass();

            authApi.path = "result_table";
            authApi.uriCreate();

            var Stream = authApi.ServerAuthorization();

            var info = JsonHelpers.ReadFromJsonStream<string>(Stream);
            dataGridView1.DataSource = JsonConvert.DeserializeObject(info, typeof(DataTable)) as DataTable;
        }
    }
}
