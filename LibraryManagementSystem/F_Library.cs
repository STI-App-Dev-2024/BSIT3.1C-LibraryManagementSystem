using LibraryManagementSystem.General_Class;
using LibraryManagementSystem.UserControl_Library;
using System.IO.Compression;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class F_Library : Form
    {
        private bool _isResized = false;
        _forUserControl addUC = new _forUserControl();
        UC_Dashboard dashboard;
        UC_Transaction transaction;
        UC_Books book;
        UC_Archive_Books books;
        UC_Archive_Student student;

        public F_Library()
        {
            InitializeComponent();
            dashboard = new UC_Dashboard();
            addUC.addUserControl(dashboard, panel2);
        }

        //This method allows the selected user control to show and place in the panel
        //private void addUserControl(UserControl usercontrol)
        //{
            
        //    usercontrol.Dock = DockStyle.Fill;
        //    panel2.Controls.Clear();
        //    panel2.Controls.Add(usercontrol);
        //    usercontrol.BringToFront();
        //}
        //This is the transition for submenu in Archive. It also move the location of the Logout button
        private void archiveTimer_Tick(object sender, EventArgs e)
        {
            if (_isResized == false)
            {
                flowArchivePanel.Height += 10;
                btnLogOut.Location = new Point(14, btnLogOut.Location.Y + 3);
                if (flowArchivePanel.Height >= 171)
                {
                    archiveTimer.Stop();
                    _isResized = true;
                }
            }
            else
            {
                flowArchivePanel.Height -= 10;
                btnLogOut.Location = new Point(14, btnLogOut.Location.Y - 3);
                if (flowArchivePanel.Height <= 57)
                {
                    archiveTimer.Stop();
                    _isResized = false;
                }
            }
        }
        
        //Loading dashboard first
        private void LBMSSidebarForm_Load(object sender, EventArgs e)
        {
            
        }
        //When clicked, it shows the transaction page
        private void btnTransaction_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            transaction = new UC_Transaction();
            addUC.addUserControl(transaction, panel2);

        }
        //When clicked, it shows a submenu, Book Archive and Transaction Archive
        private void btnArchive_Click(object sender, EventArgs e)
        {
            archiveTimer.Start();
        }
        //When clicked, it shows the book inventory page
        private void btnBookInventory_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            book = new UC_Books();
            addUC.addUserControl(book, panel2);
        }
        //When clicked, it shows the dashboard page
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            dashboard = new UC_Dashboard();
            addUC.addUserControl(dashboard, panel2);
        }
        
        //When clicked, it shows the Book Archive page
        private void btnBookArchive_Click(object sender, EventArgs e)
        {
            books = new UC_Archive_Books();
            addUC.addUserControl(books, panel2);
        }
        //When clicked, it shows the Transaction Archive page
        private void btnTransactArchive_Click(object sender, EventArgs e)
        {
            student = new UC_Archive_Student();
            addUC.addUserControl(student, panel2);
        }
    }
}
