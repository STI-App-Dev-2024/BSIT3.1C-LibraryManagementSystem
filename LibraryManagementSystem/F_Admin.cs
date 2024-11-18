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
using LibraryManagementSystem.UserControl_Admin;

namespace LibraryManagementSystem
{
    public partial class F_Admin : Form
    {
        AdminConnection admin = new AdminConnection();
        UC_ManageLibrarian manageLibrarian;
        F_AdminContainer contain;
        public F_Admin()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void F_Admin_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            UC_ManageLibrarian manageLibrarian = new UC_ManageLibrarian();
            manageLibrarian.Show();
            manageLibrarian.Dock = DockStyle.Fill;
            manageLibrarian.BringToFront();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            UC_ManageLibrarian manageLibrarian = new UC_ManageLibrarian();
            manageLibrarian.Show();
            manageLibrarian.Dock = DockStyle.Fill;
            manageLibrarian.BringToFront();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            manageLibrarian = new UC_ManageLibrarian();
            contain = new F_AdminContainer(manageLibrarian);
            contain.Show();
            this.Hide();
        }
    }
}
