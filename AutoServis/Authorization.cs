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


        private void Autorization_Load(object sender, EventArgs e)
        {
            TextBox_Password.UseSystemPasswordChar = true;
            this.KeyPreview = true;
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
            if (PasswordFlag && LoginFlag)
            {
                this.Hide();
                ClientsData ClientsDataForm = new ClientsData();             
                ClientsDataForm.Show();               
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }

        private void pictureBox_eye_Click(object sender, EventArgs e)
        {
            TextBox_Password.UseSystemPasswordChar = false;
            pictureBox_eye.Visible = false;
            pictureBox_not_eye.Visible = true;
        }

        private void pictureBox_not_eye_Click(object sender, EventArgs e)
        {
            TextBox_Password.UseSystemPasswordChar = true;
            pictureBox_not_eye.Visible = false;
            pictureBox_eye.Visible = true;  
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData ==  Keys.Enter)
            {
                buttonEnter.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
