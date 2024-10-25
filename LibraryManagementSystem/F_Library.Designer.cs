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
            btnTransaction = new Button();
            btnBookInventory = new Button();
            btnArchive = new Button();
            btnLogOut = new Button();
            btnDashboard = new Button();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTransaction
            // 
            btnTransaction.Font = new Font("Bookman Old Style", 12F);
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
            btnBookInventory.Font = new Font("Bookman Old Style", 12F);
            btnBookInventory.Location = new Point(14, 321);
            btnBookInventory.Margin = new Padding(5, 10, 5, 10);
            btnBookInventory.Name = "btnBookInventory";
            btnBookInventory.Size = new Size(327, 57);
            btnBookInventory.TabIndex = 2;
            btnBookInventory.Text = "Book Inventory";
            btnBookInventory.UseVisualStyleBackColor = true;
            // 
            // btnArchive
            // 
            btnArchive.Font = new Font("Bookman Old Style", 12F);
            btnArchive.Location = new Point(14, 398);
            btnArchive.Margin = new Padding(5, 10, 5, 10);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(327, 57);
            btnArchive.TabIndex = 3;
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = true;
            btnArchive.Click += btnArchive_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Font = new Font("Bookman Old Style", 12F);
            btnLogOut.Location = new Point(14, 563);
            btnLogOut.Margin = new Padding(5, 10, 5, 10);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(327, 57);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "Log-Out";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Bookman Old Style", 12F);
            btnDashboard.Location = new Point(14, 167);
            btnDashboard.Margin = new Padding(5, 10, 5, 10);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(327, 57);
            btnDashboard.TabIndex = 5;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnArchive);
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
            // button1
            // 
            button1.Font = new Font("Bookman Old Style", 12F);
            button1.Location = new Point(15, 30);
            button1.Margin = new Padding(5, 10, 5, 10);
            button1.Name = "button1";
            button1.Size = new Size(48, 45);
            button1.TabIndex = 5;
            button1.Text = "<<";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(369, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(895, 681);
            panel2.TabIndex = 0;
            // 
            // F_Library
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "F_Library";
            Text = "Library Management System";
            Load += LBMSSidebarForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnTransaction;
        private Button btnBookInventory;
        private Button btnArchive;
        private Button btnLogOut;
        private Button btnDashboard;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
    }
}
