﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.UserControl_Admin
{
    public partial class UC_LoginHistory : UserControl
    {
        public UC_LoginHistory()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            F_Admin admin = new F_Admin();
            admin.Show();
            this.Hide();
        }
    }
}
