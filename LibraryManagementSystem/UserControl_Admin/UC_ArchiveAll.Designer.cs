namespace LibraryManagementSystem.UserControl_Admin
{
    partial class UC_ArchiveAll
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
            btnTransact = new Button();
            btnBook = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtSearch = new TextBox();
            datagridArchive = new DataGridView();
            btnReturn = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridArchive).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 113);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1264, 113);
            label1.TabIndex = 0;
            label1.Text = "The Archive";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnTransact, 2, 0);
            tableLayoutPanel1.Controls.Add(btnBook, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 113);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1264, 55);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnTransact
            // 
            btnTransact.Dock = DockStyle.Right;
            btnTransact.Location = new Point(745, 3);
            btnTransact.Name = "btnTransact";
            btnTransact.Size = new Size(200, 49);
            btnTransact.TabIndex = 1;
            btnTransact.Text = "Transaction Archive";
            btnTransact.UseVisualStyleBackColor = true;
            // 
            // btnBook
            // 
            btnBook.Dock = DockStyle.Left;
            btnBook.Location = new Point(319, 3);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(200, 49);
            btnBook.TabIndex = 0;
            btnBook.Text = "Book Archive";
            btnBook.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.Controls.Add(txtSearch, 1, 0);
            tableLayoutPanel2.Controls.Add(datagridArchive, 1, 1);
            tableLayoutPanel2.Controls.Add(btnReturn, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 168);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Size = new Size(1264, 550);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Bottom;
            txtSearch.Location = new Point(192, 46);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(878, 33);
            txtSearch.TabIndex = 0;
            txtSearch.Text = "Search...";
            // 
            // datagridArchive
            // 
            datagridArchive.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridArchive.Dock = DockStyle.Fill;
            datagridArchive.Location = new Point(192, 85);
            datagridArchive.Name = "datagridArchive";
            datagridArchive.Size = new Size(878, 406);
            datagridArchive.TabIndex = 1;
            // 
            // btnReturn
            // 
            btnReturn.Dock = DockStyle.Top;
            btnReturn.Location = new Point(3, 3);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(183, 44);
            btnReturn.TabIndex = 2;
            btnReturn.Text = "Go back";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // UC_ArchiveAll
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "UC_ArchiveAll";
            Size = new Size(1264, 718);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagridArchive).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnTransact;
        private Button btnBook;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtSearch;
        private DataGridView datagridArchive;
        private Button btnReturn;
    }
}
