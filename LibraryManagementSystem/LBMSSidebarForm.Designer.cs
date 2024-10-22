namespace LibraryManagementSystem
{
    partial class LBMSSidebarForm
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
            panel2 = new Panel();
            userControlArchive1 = new UserControlArchive();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnTransaction
            // 
            btnTransaction.Location = new Point(15, 244);
            btnTransaction.Margin = new Padding(5, 10, 5, 10);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Size = new Size(319, 57);
            btnTransaction.TabIndex = 0;
            btnTransaction.Text = "Transaction";
            btnTransaction.UseVisualStyleBackColor = true;
            // 
            // btnBookInventory
            // 
            btnBookInventory.Location = new Point(15, 321);
            btnBookInventory.Margin = new Padding(5, 10, 5, 10);
            btnBookInventory.Name = "btnBookInventory";
            btnBookInventory.Size = new Size(319, 57);
            btnBookInventory.TabIndex = 2;
            btnBookInventory.Text = "Book Inventory";
            btnBookInventory.UseVisualStyleBackColor = true;
            // 
            // btnArchive
            // 
            btnArchive.Location = new Point(15, 398);
            btnArchive.Margin = new Padding(5, 10, 5, 10);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(319, 57);
            btnArchive.TabIndex = 3;
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(15, 563);
            btnLogOut.Margin = new Padding(5, 10, 5, 10);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(319, 57);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "Log-Out";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(15, 167);
            btnDashboard.Margin = new Padding(5, 10, 5, 10);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(319, 57);
            btnDashboard.TabIndex = 5;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogOut);
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
            // panel2
            // 
            panel2.Controls.Add(userControlArchive1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(369, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(895, 681);
            panel2.TabIndex = 7;
            // 
            // userControlArchive1
            // 
            userControlArchive1.Location = new Point(0, 0);
            userControlArchive1.Name = "userControlArchive1";
            userControlArchive1.Size = new Size(895, 681);
            userControlArchive1.TabIndex = 0;
            // 
            // LBMSSidebarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LBMSSidebarForm";
            Text = "Library Management System";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
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
        private UserControlArchive userControlArchive1;
    }
}
