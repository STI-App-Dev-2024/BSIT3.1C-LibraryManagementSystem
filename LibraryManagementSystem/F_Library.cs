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
            
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
