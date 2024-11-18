using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.General_Class
{
    internal class AdminConnection
    {
        private UserControl _userControl;
        public void UCToAdmin(UserControl userControl)
        {
            _userControl = userControl;
        }

        public void adminToUC(Panel panel)
        {
            _userControl.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(_userControl);
            _userControl.BringToFront();
        }
    }
}
