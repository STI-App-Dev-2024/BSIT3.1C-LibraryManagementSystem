using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.UserControl_Library
{
    public partial class UC_Archive_Student : UserControl
    {
        public UC_Archive_Student()
        {
            InitializeComponent();
        }

        private void searchBtxt_Enter(object sender, EventArgs e)
        {
            if (searchBtxt.Text.Equals("Enter Student Number or Name"))
            {
                searchBtxt.Text = "";
                searchBtxt.ForeColor = Color.Black;
            }
        }

        private void searchBtxt_Leave(object sender, EventArgs e)
        {
            if (searchBtxt.Text.Equals(""))
            {
                searchBtxt.Text = "Enter Student Number or Name";
                searchBtxt.ForeColor = Color.LightGray;
            }
        }
    }
}
