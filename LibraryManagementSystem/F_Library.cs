using LibraryManagementSystem.UserControl_Library;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class F_Library : Form
    {


        public F_Library()
        {
            InitializeComponent();
            panel2.Controls.Clear();
        }


        private void addUserControl(UserControl usercontrol)
        {
            usercontrol.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }
        private void LBMSSidebarForm_Load(object sender, EventArgs e)
        {
            UC_Dashboard dashboard = new UC_Dashboard();
            addUserControl(dashboard);
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UC_Transaction transaction = new UC_Transaction();
            addUserControl(transaction);
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            

        }

        private void btnBookInventory_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UC_Books book = new UC_Books();
            addUserControl(book);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UC_Dashboard dashboard = new UC_Dashboard();
            addUserControl(dashboard);
        }
    }
}
