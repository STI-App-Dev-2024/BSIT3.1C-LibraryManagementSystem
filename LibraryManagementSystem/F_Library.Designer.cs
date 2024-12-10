namespace LibraryManagementSystem
{
    partial class F_Library
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Library));
            btnTransaction = new Button();
            btnBookInventory = new Button();
            btnArchive = new Button();
            btnLogOut = new Button();
            btnDashboard = new Button();
            panel1 = new Panel();
            lbl_Name = new Label();
            flowArchivePanel = new FlowLayoutPanel();
            btnBookArchive = new Button();
            btnTransactArchive = new Button();
            panel2 = new Panel();
            archiveTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            flowArchivePanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnTransaction
            // 
            btnTransaction.Font = new Font("Segoe UI", 14.25F);
            btnTransaction.Image = (Image)resources.GetObject("btnTransaction.Image");
            btnTransaction.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransaction.Location = new Point(14, 244);
            btnTransaction.Margin = new Padding(5, 10, 5, 10);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Size = new Size(327, 57);
            btnTransaction.TabIndex = 0;
            btnTransaction.Text = "Transaction";
            btnTransaction.UseVisualStyleBackColor = true;
            btnTransaction.Click += btnTransaction_Click;
            // 
            // btnBookInventory
            // 
            btnBookInventory.Font = new Font("Segoe UI", 14.25F);
            btnBookInventory.Image = (Image)resources.GetObject("btnBookInventory.Image");
            btnBookInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnBookInventory.Location = new Point(14, 321);
            btnBookInventory.Margin = new Padding(5, 10, 5, 10);
            btnBookInventory.Name = "btnBookInventory";
            btnBookInventory.Size = new Size(327, 57);
            btnBookInventory.TabIndex = 2;
            btnBookInventory.Text = "Book Inventory";
            btnBookInventory.UseVisualStyleBackColor = true;
            btnBookInventory.Click += btnBookInventory_Click;
            // 
            // btnArchive
            // 
            btnArchive.Font = new Font("Segoe UI", 14.25F);
            btnArchive.Location = new Point(0, 0);
            btnArchive.Margin = new Padding(0);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(327, 57);
            btnArchive.TabIndex = 3;
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = true;
            btnArchive.Click += btnArchive_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Font = new Font("Segoe UI", 14.25F);
            btnLogOut.ForeColor = SystemColors.ActiveCaptionText;
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(14, 563);
            btnLogOut.Margin = new Padding(5, 10, 5, 10);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(327, 57);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "Log-Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(14, 167);
            btnDashboard.Margin = new Padding(5, 10, 5, 10);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(327, 57);
            btnDashboard.TabIndex = 5;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(lbl_Name);
            panel1.Controls.Add(flowArchivePanel);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnTransaction);
            panel1.Controls.Add(btnBookInventory);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(356, 681);
            panel1.TabIndex = 6;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.BackColor = Color.Transparent;
            lbl_Name.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Name.ForeColor = Color.WhiteSmoke;
            lbl_Name.Location = new Point(87, 65);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(0, 25);
            lbl_Name.TabIndex = 6;
            // 
            // flowArchivePanel
            // 
            flowArchivePanel.BackColor = Color.Transparent;
            flowArchivePanel.Controls.Add(btnArchive);
            flowArchivePanel.Controls.Add(btnBookArchive);
            flowArchivePanel.Controls.Add(btnTransactArchive);
            flowArchivePanel.Location = new Point(15, 398);
            flowArchivePanel.Margin = new Padding(5, 10, 5, 10);
            flowArchivePanel.Name = "flowArchivePanel";
            flowArchivePanel.Size = new Size(327, 57);
            flowArchivePanel.TabIndex = 0;
            // 
            // btnBookArchive
            // 
            btnBookArchive.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBookArchive.Image = (Image)resources.GetObject("btnBookArchive.Image");
            btnBookArchive.ImageAlign = ContentAlignment.MiddleLeft;
            btnBookArchive.Location = new Point(0, 57);
            btnBookArchive.Margin = new Padding(0);
            btnBookArchive.Name = "btnBookArchive";
            btnBookArchive.Size = new Size(327, 57);
            btnBookArchive.TabIndex = 0;
            btnBookArchive.Text = "Book";
            btnBookArchive.UseVisualStyleBackColor = true;
            btnBookArchive.Click += btnBookArchive_Click;
            // 
            // btnTransactArchive
            // 
            btnTransactArchive.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransactArchive.Image = (Image)resources.GetObject("btnTransactArchive.Image");
            btnTransactArchive.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransactArchive.Location = new Point(0, 114);
            btnTransactArchive.Margin = new Padding(0);
            btnTransactArchive.Name = "btnTransactArchive";
            btnTransactArchive.Size = new Size(327, 57);
            btnTransactArchive.TabIndex = 1;
            btnTransactArchive.Text = "Transaction";
            btnTransactArchive.UseVisualStyleBackColor = true;
            btnTransactArchive.Click += btnTransactArchive_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(361, 12);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(25);
            panel2.Size = new Size(898, 657);
            panel2.TabIndex = 0;
            // 
            // archiveTimer
            // 
            archiveTimer.Interval = 20;
            archiveTimer.Tick += archiveTimer_Tick;
            // 
            // F_Library
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "F_Library";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Management System";
            WindowState = FormWindowState.Maximized;
            Load += LBMSSidebarForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowArchivePanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTransaction;
        private Button btnBookInventory;
        private Button btnArchive;
        private Button btnLogOut;
        private Button btnDashboard;
        private Panel panel1;
        private Panel panel2;
        private System.Windows.Forms.Timer archiveTimer;
        private FlowLayoutPanel flowArchivePanel;
        private Button btnTransactArchive;
        private Button btnBookArchive;
        private Label lbl_Name;
    }
}
