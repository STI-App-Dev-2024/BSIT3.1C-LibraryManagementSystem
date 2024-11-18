using LibraryManagementSystem.General_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class F_AdminContainer : Form
    {
        AdminConnection connect = new AdminConnection();
        public F_AdminContainer(UserControl user)
        {
            InitializeComponent();
            connect.UCToAdmin(user);
        }

        private void F_AdminContainer_Load(object sender, EventArgs e)
        {
            connect.adminToUC(panelOver);
        }

        private void F_AdminContainer_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
            //MessageBox.Show("Go back on main menu before closing.");
        }
    }
}
