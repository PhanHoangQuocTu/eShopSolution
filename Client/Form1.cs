using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public class Employee
        {
            public int Id { get; set; }
            public string Code { get; set; }
            public string Name { get; set; }
            public string BirthDay { get; set; }
            public string Gender { get; set; }
            public string BirthPlace { get; set; }
            public int Age { get; set; }
            public string Address { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Uri Url = new Uri("https://raw.githubusercontent.com/dinhtona/api-mssql-dapper/main/db.json");
            var restClient = new RestClient(Url);
            RestRequest restRequest = new RestRequest("", Method.Get);
            var restResponse = restClient.Execute<List<Employee>>(restRequest);

            if (restResponse.IsSuccessful)
            {
                var employee = restResponse.Data;
                dataGridView1.DataSource = employee;
            }
            else
            {
                Console.WriteLine(restResponse.ErrorMessage);
            }
        }
    }
}
