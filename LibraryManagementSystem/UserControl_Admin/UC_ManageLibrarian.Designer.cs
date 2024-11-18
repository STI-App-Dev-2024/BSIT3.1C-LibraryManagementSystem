namespace LibraryManagementSystem.UserControl_Admin
{
    partial class UC_ManageLibrarian
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnReturn = new Button();
            panel5 = new Panel();
            datagridAccounts = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel4 = new Panel();
            txtSearch = new TextBox();
            panel6 = new Panel();
            btnNewAccnt = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridAccounts).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 104);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1264, 104);
            label1.TabIndex = 0;
            label1.Text = "Manage Librarian Accounts";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Controls.Add(btnReturn, 0, 0);
            tableLayoutPanel1.Controls.Add(panel5, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(1264, 614);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(3, 3);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(183, 52);
            btnReturn.TabIndex = 0;
            btnReturn.Text = "Go back";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(datagridAccounts);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(192, 95);
            panel5.Name = "panel5";
            panel5.Size = new Size(878, 423);
            panel5.TabIndex = 1;
            // 
            // datagridAccounts
            // 
            datagridAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridAccounts.Dock = DockStyle.Fill;
            datagridAccounts.Location = new Point(0, 0);
            datagridAccounts.Name = "datagridAccounts";
            datagridAccounts.Size = new Size(878, 423);
            datagridAccounts.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.Controls.Add(panel4, 0, 0);
            tableLayoutPanel2.Controls.Add(panel6, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(192, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(878, 86);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtSearch);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(520, 80);
            panel4.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Bottom;
            txtSearch.Location = new Point(0, 47);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(520, 33);
            txtSearch.TabIndex = 0;
            txtSearch.Text = "Type the name or ID number";
            // 
            // panel6
            // 
            panel6.Controls.Add(btnNewAccnt);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(529, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(346, 80);
            panel6.TabIndex = 1;
            // 
            // btnNewAccnt
            // 
            btnNewAccnt.Dock = DockStyle.Bottom;
            btnNewAccnt.Location = new Point(0, 47);
            btnNewAccnt.Name = "btnNewAccnt";
            btnNewAccnt.Size = new Size(346, 33);
            btnNewAccnt.TabIndex = 0;
            btnNewAccnt.Text = "New Librarian Account";
            btnNewAccnt.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(1264, 614);
            panel2.TabIndex = 1;
            // 
            // UC_ManageLibrarian
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "UC_ManageLibrarian";
            Size = new Size(1264, 718);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datagridAccounts).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
        private DataGridView datagridAccounts;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel4;
        private TextBox txtSearch;
        private Panel panel6;
        private Button btnNewAccnt;
        private Panel panel2;
        private Button btnReturn;
    }
}
