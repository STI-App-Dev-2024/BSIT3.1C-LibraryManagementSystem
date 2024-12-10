using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.General_Class;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem.UserControl_Login
{
    public partial class UC_Login : UserControl
    {
        SqlConnection conn = new SqlConnection();
        public UC_Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Login(txtEmail.Text, txtPassword.Text);
            
        }
    }
}
