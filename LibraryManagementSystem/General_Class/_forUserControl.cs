using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.General_Class
{
    internal class _forUserControl
    {
        public void addUserControl(UserControl usercontrol, Panel panel2)
        {
            
            panel2.Controls.Clear();
            panel2.Controls.Add(usercontrol);
            usercontrol.Dock = DockStyle.Fill;
            usercontrol.BringToFront();
        }
    }
}
