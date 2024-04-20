using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace AutoServis
{
    public partial class ClientsData : Form
    {
        private SqlConnection SqlConnection = null;
        public ClientsData()
        {
            InitializeComponent();
        }

        private void ClientsData_Load(object sender, EventArgs e)
        {
            SqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ClientsDB"].ConnectionString);
            SqlConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
              "SELECT * FROM Clients", SqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void button_Add_Client(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
                $"INSERT INTO [Clients] (Name, Surname, Birthday, Phone, Email, CarType) VALUES (@Name, @Surname, @Birthday, @Phone, @Email, @CarType)",
                SqlConnection);

            DateTime date = DateTime.Parse(textBox_birthday.Text);

            command.Parameters.AddWithValue("Name", textBox_name.Text);
            command.Parameters.AddWithValue("Surname", textBox_surname.Text);
            command.Parameters.AddWithValue("Birthday", $"{date.Month}/{date.Day}/{date.Year}");
            command.Parameters.AddWithValue("Phone",textBox_phone.Text);
            command.Parameters.AddWithValue("Email", textBox_email.Text);
            command.Parameters.AddWithValue("CarType", textBox_car_type.Text);
            command.ExecuteNonQuery();
            UpdateData();
            textBox_name.Clear();
            textBox_surname.Clear();
            textBox_birthday.Clear();
            textBox_phone.Clear();
            textBox_email.Clear();
            textBox_car_type.Clear();
        }

        private void UpdateData()
        {  
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
             "SELECT * FROM Clients", SqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

    }
}
