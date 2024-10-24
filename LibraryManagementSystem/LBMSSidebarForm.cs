namespace LibraryManagementSystem
{
    public partial class LBMSSidebarForm : Form
    {
        
        public LBMSSidebarForm()
        {
            InitializeComponent();
            UserControlArchive archive = new UserControlArchive();
            UserControlTransac transac = new UserControlTransac();
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
            
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            UserControlTransac transac = new UserControlTransac();
            addUserControl(transac);
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            UserControlArchive archive = new UserControlArchive();
            addUserControl(archive);
        }
    }
}
