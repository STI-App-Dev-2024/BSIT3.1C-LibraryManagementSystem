namespace LibraryManagementSystem
{
    partial class F_Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Admin));
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ButtonsPanel = new TableLayoutPanel();
            panel7 = new Panel();
            picHistory = new PictureBox();
            lblHistory = new Label();
            panel6 = new Panel();
            picArchive = new PictureBox();
            lblArchive = new Label();
            panel5 = new Panel();
            picLogout = new PictureBox();
            lblLogout = new Label();
            panel4 = new Panel();
            picAccnt = new PictureBox();
            lblAccnt = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            PendingBarPanel = new TableLayoutPanel();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ButtonsPanel.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHistory).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picArchive).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogout).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAccnt).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            PendingBarPanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Top;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(322, 68);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(321, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(321, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // ButtonsPanel
            // 
            ButtonsPanel.BackColor = Color.Transparent;
            ButtonsPanel.ColumnCount = 2;
            ButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ButtonsPanel.Controls.Add(panel7, 1, 1);
            ButtonsPanel.Controls.Add(panel6, 1, 0);
            ButtonsPanel.Controls.Add(panel5, 0, 1);
            ButtonsPanel.Controls.Add(panel4, 0, 0);
            ButtonsPanel.Dock = DockStyle.Fill;
            ButtonsPanel.Location = new Point(0, 223);
            ButtonsPanel.Margin = new Padding(10);
            ButtonsPanel.Name = "ButtonsPanel";
            ButtonsPanel.RowCount = 2;
            ButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.10101F));
            ButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 49.89899F));
            ButtonsPanel.Size = new Size(1264, 549);
            ButtonsPanel.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkSeaGreen;
            panel7.Controls.Add(picHistory);
            panel7.Controls.Add(lblHistory);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(652, 295);
            panel7.Margin = new Padding(20);
            panel7.Name = "panel7";
            panel7.Size = new Size(592, 234);
            panel7.TabIndex = 1;
            // 
            // picHistory
            // 
            picHistory.Dock = DockStyle.Bottom;
            picHistory.Image = (Image)resources.GetObject("picHistory.Image");
            picHistory.Location = new Point(0, 0);
            picHistory.Name = "picHistory";
            picHistory.Size = new Size(592, 129);
            picHistory.SizeMode = PictureBoxSizeMode.Zoom;
            picHistory.TabIndex = 3;
            picHistory.TabStop = false;
            picHistory.Click += picHistory_Click;
            // 
            // lblHistory
            // 
            lblHistory.Dock = DockStyle.Bottom;
            lblHistory.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHistory.Location = new Point(0, 129);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(592, 105);
            lblHistory.TabIndex = 3;
            lblHistory.Text = "Log in History";
            lblHistory.TextAlign = ContentAlignment.MiddleCenter;
            lblHistory.Click += label9_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DeepSkyBlue;
            panel6.Controls.Add(picArchive);
            panel6.Controls.Add(lblArchive);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(652, 20);
            panel6.Margin = new Padding(20);
            panel6.Name = "panel6";
            panel6.Size = new Size(592, 235);
            panel6.TabIndex = 1;
            // 
            // picArchive
            // 
            picArchive.Dock = DockStyle.Bottom;
            picArchive.Image = (Image)resources.GetObject("picArchive.Image");
            picArchive.Location = new Point(0, 0);
            picArchive.Name = "picArchive";
            picArchive.Size = new Size(592, 139);
            picArchive.SizeMode = PictureBoxSizeMode.Zoom;
            picArchive.TabIndex = 1;
            picArchive.TabStop = false;
            picArchive.Click += picArchive_Click;
            // 
            // lblArchive
            // 
            lblArchive.Dock = DockStyle.Bottom;
            lblArchive.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArchive.Location = new Point(0, 139);
            lblArchive.Name = "lblArchive";
            lblArchive.Size = new Size(592, 96);
            lblArchive.TabIndex = 4;
            lblArchive.Text = "Archives";
            lblArchive.TextAlign = ContentAlignment.MiddleCenter;
            lblArchive.Click += label10_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.MediumPurple;
            panel5.Controls.Add(picLogout);
            panel5.Controls.Add(lblLogout);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(20, 295);
            panel5.Margin = new Padding(20);
            panel5.Name = "panel5";
            panel5.Size = new Size(592, 234);
            panel5.TabIndex = 1;
            // 
            // picLogout
            // 
            picLogout.Dock = DockStyle.Bottom;
            picLogout.Image = (Image)resources.GetObject("picLogout.Image");
            picLogout.Location = new Point(0, 0);
            picLogout.Name = "picLogout";
            picLogout.Size = new Size(592, 129);
            picLogout.SizeMode = PictureBoxSizeMode.Zoom;
            picLogout.TabIndex = 2;
            picLogout.TabStop = false;
            picLogout.Click += picLogout_Click;
            // 
            // lblLogout
            // 
            lblLogout.Dock = DockStyle.Bottom;
            lblLogout.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogout.Location = new Point(0, 129);
            lblLogout.Name = "lblLogout";
            lblLogout.Size = new Size(592, 105);
            lblLogout.TabIndex = 2;
            lblLogout.Text = "Log out";
            lblLogout.TextAlign = ContentAlignment.MiddleCenter;
            lblLogout.Click += lblLogout_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkOrange;
            panel4.Controls.Add(picAccnt);
            panel4.Controls.Add(lblAccnt);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(20, 20);
            panel4.Margin = new Padding(20);
            panel4.Name = "panel4";
            panel4.Size = new Size(592, 235);
            panel4.TabIndex = 0;
            panel4.Click += panel4_Click;
            // 
            // picAccnt
            // 
            picAccnt.Dock = DockStyle.Bottom;
            picAccnt.Image = (Image)resources.GetObject("picAccnt.Image");
            picAccnt.Location = new Point(0, 0);
            picAccnt.Name = "picAccnt";
            picAccnt.Size = new Size(592, 139);
            picAccnt.SizeMode = PictureBoxSizeMode.Zoom;
            picAccnt.TabIndex = 0;
            picAccnt.TabStop = false;
            picAccnt.Click += pictureBox4_Click;
            // 
            // lblAccnt
            // 
            lblAccnt.Dock = DockStyle.Bottom;
            lblAccnt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccnt.Location = new Point(0, 139);
            lblAccnt.Name = "lblAccnt";
            lblAccnt.Size = new Size(592, 96);
            lblAccnt.TabIndex = 1;
            lblAccnt.Text = "Manage Librarian Account";
            lblAccnt.TextAlign = ContentAlignment.MiddleCenter;
            lblAccnt.Click += label7_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(50, 20);
            panel1.Margin = new Padding(50, 0, 50, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 203);
            panel1.TabIndex = 2;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Bottom;
            label6.Font = new Font("Segoe UI", 14.25F);
            label6.Location = new Point(0, 71);
            label6.Name = "label6";
            label6.Size = new Size(321, 45);
            label6.TabIndex = 5;
            label6.Text = "100";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Bottom;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(0, 116);
            label5.Name = "label5";
            label5.Size = new Size(321, 87);
            label5.TabIndex = 5;
            label5.Text = "Pending Reset Request From Librarian";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Lime;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(471, 20);
            panel3.Margin = new Padding(50, 0, 50, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(321, 203);
            panel3.TabIndex = 3;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(0, 71);
            label1.Name = "label1";
            label1.Size = new Size(321, 44);
            label1.TabIndex = 6;
            label1.Text = "100";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(0, 115);
            label2.Name = "label2";
            label2.Size = new Size(321, 88);
            label2.TabIndex = 7;
            label2.Text = "Total transactions recorded";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PendingBarPanel
            // 
            PendingBarPanel.BackColor = Color.Transparent;
            PendingBarPanel.ColumnCount = 3;
            PendingBarPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            PendingBarPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            PendingBarPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            PendingBarPanel.Controls.Add(panel2, 2, 1);
            PendingBarPanel.Controls.Add(panel1, 0, 1);
            PendingBarPanel.Controls.Add(panel3, 1, 1);
            PendingBarPanel.Dock = DockStyle.Top;
            PendingBarPanel.Location = new Point(0, 0);
            PendingBarPanel.Name = "PendingBarPanel";
            PendingBarPanel.RowCount = 2;
            PendingBarPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            PendingBarPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PendingBarPanel.Size = new Size(1264, 223);
            PendingBarPanel.TabIndex = 4;
            PendingBarPanel.Paint += tableLayoutPanel1_Paint;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Turquoise;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(892, 20);
            panel2.Margin = new Padding(50, 0, 50, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(322, 203);
            panel2.TabIndex = 3;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(0, 71);
            label3.Name = "label3";
            label3.Size = new Size(322, 60);
            label3.TabIndex = 9;
            label3.Text = "100";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Bottom;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(0, 131);
            label4.Name = "label4";
            label4.Size = new Size(322, 72);
            label4.TabIndex = 10;
            label4.Text = "Total Books (Duplicate not included)";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // F_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 772);
            Controls.Add(ButtonsPanel);
            Controls.Add(PendingBarPanel);
            DoubleBuffered = true;
            Name = "F_Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormsAdminOverview";
            WindowState = FormWindowState.Maximized;
            Load += F_Admin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ButtonsPanel.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picHistory).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picArchive).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogout).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAccnt).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            PendingBarPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private TableLayoutPanel ButtonsPanel;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private PictureBox picAccnt;
        private PictureBox picHistory;
        private PictureBox picArchive;
        private PictureBox picLogout;
        private Label lblAccnt;
        private Label lblHistory;
        private Label lblArchive;
        private Label lblLogout;
        private Panel panel1;
        private Panel panel3;
        private TableLayoutPanel PendingBarPanel;
        private Label label6;
        private Label label5;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Label label4;
    }
}