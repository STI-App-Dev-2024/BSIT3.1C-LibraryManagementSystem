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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            Filterbtn = new Button();
            searchBtxt = new TextBox();
            panel4 = new Panel();
            TransacGrid = new DataGridView();
            StuNo = new DataGridViewTextBoxColumn();
            StuName = new DataGridViewTextBoxColumn();
            dateBorrow = new DataGridViewTextBoxColumn();
            SystemPanel2.SuspendLayout();
            TransacPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TransacGrid).BeginInit();
            SuspendLayout();
            // 
            // SystemPanel2
            // 
            SystemPanel2.Controls.Add(label1);
            SystemPanel2.Dock = DockStyle.Top;
            SystemPanel2.Location = new Point(0, 0);
            SystemPanel2.Name = "SystemPanel2";
            SystemPanel2.Size = new Size(895, 70);
            SystemPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 25);
            label1.Name = "label1";
            label1.Size = new Size(276, 21);
            label1.TabIndex = 0;
            label1.Text = "Student Transaction History";
            // 
            // TransacPanel
            // 
            TransacPanel.Controls.Add(tableLayoutPanel1);
            TransacPanel.Dock = DockStyle.Fill;
            TransacPanel.Location = new Point(0, 70);
            TransacPanel.Margin = new Padding(0);
            TransacPanel.Name = "TransacPanel";
            TransacPanel.Size = new Size(895, 611);
            TransacPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 0, 1);
            tableLayoutPanel1.Location = new Point(64, 33);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.1059246F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86.89407F));
            tableLayoutPanel1.Size = new Size(760, 546);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(Filterbtn);
            panel3.Controls.Add(searchBtxt);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(754, 65);
            panel3.TabIndex = 0;
            // 
            // Filterbtn
            // 
            Filterbtn.Location = new Point(623, 18);
            Filterbtn.Name = "Filterbtn";
            Filterbtn.Size = new Size(128, 30);
            Filterbtn.TabIndex = 1;
            Filterbtn.Text = "Filter by";
            Filterbtn.UseVisualStyleBackColor = true;
            // 
            // searchBtxt
            // 
            searchBtxt.Location = new Point(3, 18);
            searchBtxt.Name = "searchBtxt";
            searchBtxt.Size = new Size(489, 30);
            searchBtxt.TabIndex = 0;
            searchBtxt.Text = "Enter Student Number or Name";
            // 
            // panel4
            // 
            panel4.Controls.Add(TransacGrid);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 74);
            panel4.Name = "panel4";
            panel4.Size = new Size(754, 469);
            panel4.TabIndex = 1;
            // 
            // TransacGrid
            // 
            TransacGrid.AllowUserToAddRows = false;
            TransacGrid.AllowUserToDeleteRows = false;
            TransacGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TransacGrid.Columns.AddRange(new DataGridViewColumn[] { StuNo, StuName, dateBorrow });
            TransacGrid.Dock = DockStyle.Fill;
            TransacGrid.Location = new Point(0, 0);
            TransacGrid.Name = "TransacGrid";
            TransacGrid.ReadOnly = true;
            TransacGrid.Size = new Size(754, 469);
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
            // UC_Archive_Student
            // 
            AutoScaleDimensions = new SizeF(12F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TransacPanel);
            Controls.Add(SystemPanel2);
            Font = new Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "UC_Archive_Student";
            Size = new Size(895, 681);
            SystemPanel2.ResumeLayout(false);
            SystemPanel2.PerformLayout();
            TransacPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TransacGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel SystemPanel2;
        private Label label1;
        private Panel TransacPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Button Filterbtn;
        private TextBox searchBtxt;
        private Panel panel4;
        private DataGridView TransacGrid;
        private DataGridViewTextBoxColumn StuNo;
        private DataGridViewTextBoxColumn StuName;
        private DataGridViewTextBoxColumn dateBorrow;
    }
}
