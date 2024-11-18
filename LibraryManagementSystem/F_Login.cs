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

namespace LibraryManagementSystem
{
    public partial class F_Login : Form
    {
        _forUserControl user;
        UC_Login login;
        public F_Login()
        {
            InitializeComponent();
            login = new UC_Login();
            user  = new _forUserControl();
            user.addUserControl(login, panelLogin);
        }

        private void F_Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
