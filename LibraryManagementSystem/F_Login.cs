using LibraryManagementSystem.General_Class;
using LibraryManagementSystem.UserControl_Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace LibraryManagementSystem
{
    public partial class F_Login : Form
    {
        SqlConnection connect = new SqlConnection();
        
        public F_Login()
        {
            InitializeComponent();
        }

        private void F_Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connect.Login(txtEmail.Text, txtPassword.Text);
            this.Hide();
        }

        private void linkReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        
    }
}
