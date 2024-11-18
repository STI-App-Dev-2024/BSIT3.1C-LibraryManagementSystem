namespace LibraryManagementSystem.UserControl_Library
{
    partial class UC_Archive_Student
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
            SystemPanel2 = new Panel();
            label1 = new Label();
            TransacPanel = new Panel();
            TransacGrid = new DataGridView();
            StuNo = new DataGridViewTextBoxColumn();
            StuName = new DataGridViewTextBoxColumn();
            dateBorrow = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            Filterbtn = new Button();
            searchBtxt = new TextBox();
            SystemPanel2.SuspendLayout();
            TransacPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TransacGrid).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // SystemPanel2
            // 
            SystemPanel2.Controls.Add(label1);
            SystemPanel2.Dock = DockStyle.Top;
            SystemPanel2.Location = new Point(0, 0);
            SystemPanel2.Name = "SystemPanel2";
            SystemPanel2.Size = new Size(912, 134);
            SystemPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(912, 96);
            label1.TabIndex = 0;
            label1.Text = "Student Transaction History";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TransacPanel
            // 
            TransacPanel.AutoSize = true;
            TransacPanel.Controls.Add(TransacGrid);
            TransacPanel.Controls.Add(tableLayoutPanel1);
            TransacPanel.Dock = DockStyle.Fill;
            TransacPanel.Location = new Point(0, 134);
            TransacPanel.Margin = new Padding(0);
            TransacPanel.Name = "TransacPanel";
            TransacPanel.Size = new Size(912, 577);
            TransacPanel.TabIndex = 1;
            // 
            // TransacGrid
            // 
            TransacGrid.AllowUserToAddRows = false;
            TransacGrid.AllowUserToDeleteRows = false;
            TransacGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TransacGrid.Columns.AddRange(new DataGridViewColumn[] { StuNo, StuName, dateBorrow });
            TransacGrid.Dock = DockStyle.Fill;
            TransacGrid.Location = new Point(0, 43);
            TransacGrid.Name = "TransacGrid";
            TransacGrid.ReadOnly = true;
            TransacGrid.Size = new Size(912, 534);
            TransacGrid.TabIndex = 0;
            // 
            // StuNo
            // 
            StuNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StuNo.HeaderText = "Student No.";
            StuNo.Name = "StuNo";
            StuNo.ReadOnly = true;
            // 
            // StuName
            // 
            StuName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StuName.HeaderText = "Name";
            StuName.Name = "StuName";
            StuName.ReadOnly = true;
            // 
            // dateBorrow
            // 
            dateBorrow.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateBorrow.HeaderText = "Borrowing Date";
            dateBorrow.Name = "dateBorrow";
            dateBorrow.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.41228F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.587719F));
            tableLayoutPanel1.Controls.Add(Filterbtn, 1, 0);
            tableLayoutPanel1.Controls.Add(searchBtxt, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(912, 43);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Filterbtn
            // 
            Filterbtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Filterbtn.Font = new Font("Segoe UI", 14.25F);
            Filterbtn.Location = new Point(709, 6);
            Filterbtn.Name = "Filterbtn";
            Filterbtn.Size = new Size(200, 30);
            Filterbtn.TabIndex = 1;
            Filterbtn.Text = "Filter by";
            Filterbtn.UseVisualStyleBackColor = true;
            // 
            // searchBtxt
            // 
            searchBtxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            searchBtxt.Font = new Font("Segoe UI", 14.25F);
            searchBtxt.ForeColor = SystemColors.WindowText;
            searchBtxt.Location = new Point(3, 5);
            searchBtxt.Name = "searchBtxt";
            searchBtxt.Size = new Size(700, 33);
            searchBtxt.TabIndex = 0;
            searchBtxt.Text = "Enter Student Number or Name";
            searchBtxt.Enter += searchBtxt_Enter;
            searchBtxt.Leave += searchBtxt_Leave;
            // 
            // UC_Archive_Student
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TransacPanel);
            Controls.Add(SystemPanel2);
            Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "UC_Archive_Student";
            Size = new Size(912, 711);
            SystemPanel2.ResumeLayout(false);
            TransacPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TransacGrid).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel SystemPanel2;
        private Label label1;
        private Panel TransacPanel;
        private Button Filterbtn;
        private TextBox searchBtxt;
        private DataGridView TransacGrid;
        private DataGridViewTextBoxColumn StuNo;
        private DataGridViewTextBoxColumn StuName;
        private DataGridViewTextBoxColumn dateBorrow;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
