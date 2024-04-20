using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace AutoServis
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }
        private bool LoginFlag = false;
        private bool PasswordFlag = false;
        private void LoginLabel(object sender, EventArgs e)
        {

        }

        private void textBox_Login(object sender, EventArgs e)
        {
            if(TextBox_Login.Text == "Admin") 
            {
                LoginFlag = true;
            }
            else {
                LoginFlag = false;
            }
        }

        private void passwordLabel(object sender, EventArgs e)
        {

        }

        private void Autorization_Load(object sender, EventArgs e)
        {

        }

        private void textBox_Password(object sender, EventArgs e)
        {
            if (TextBox_Password.Text == "12345")
            {
                PasswordFlag = true;
            }
            else{
                PasswordFlag = false;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(PasswordFlag && LoginFlag) 
            {
                ClientsData f = new ClientsData();
                f.Show();
            }
        }

       
    }
}
