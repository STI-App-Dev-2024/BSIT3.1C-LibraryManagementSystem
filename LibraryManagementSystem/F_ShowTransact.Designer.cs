namespace LibraryManagementSystem
{
    partial class F_ShowTransact
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
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblDue = new Label();
            label6 = new Label();
            lblBorrow = new Label();
            label3 = new Label();
            lblStuNo = new Label();
            label4 = new Label();
            lblName = new Label();
            label2 = new Label();
            panel2 = new Panel();
            dgvResults = new DataGridView();
            title = new DataGridViewTextBoxColumn();
            author = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(499, 56);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(499, 56);
            label1.TabIndex = 0;
            label1.Text = "Books borrowed";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblDue, 1, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 3);
            tableLayoutPanel1.Controls.Add(lblBorrow, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(lblStuNo, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(lblName, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 56);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(499, 183);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblDue
            // 
            lblDue.Dock = DockStyle.Fill;
            lblDue.Location = new Point(252, 135);
            lblDue.Name = "lblDue";
            lblDue.Size = new Size(244, 48);
            lblDue.TabIndex = 7;
            lblDue.Text = "Student Number:";
            lblDue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 135);
            label6.Name = "label6";
            label6.Size = new Size(243, 48);
            label6.TabIndex = 6;
            label6.Text = "Due Date:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblBorrow
            // 
            lblBorrow.Dock = DockStyle.Fill;
            lblBorrow.Location = new Point(252, 90);
            lblBorrow.Name = "lblBorrow";
            lblBorrow.Size = new Size(244, 45);
            lblBorrow.TabIndex = 5;
            lblBorrow.Text = "Student Number:";
            lblBorrow.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 90);
            label3.Name = "label3";
            label3.Size = new Size(243, 45);
            label3.TabIndex = 4;
            label3.Text = "Date Borrowed:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblStuNo
            // 
            lblStuNo.Dock = DockStyle.Fill;
            lblStuNo.Location = new Point(252, 45);
            lblStuNo.Name = "lblStuNo";
            lblStuNo.Size = new Size(244, 45);
            lblStuNo.TabIndex = 3;
            lblStuNo.Text = "Name:";
            lblStuNo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 45);
            label4.Name = "label4";
            label4.Size = new Size(243, 45);
            label4.TabIndex = 2;
            label4.Text = "Student Number:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            lblName.Dock = DockStyle.Fill;
            lblName.Location = new Point(252, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(244, 45);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(243, 45);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvResults);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 239);
            panel2.Name = "panel2";
            panel2.Size = new Size(499, 283);
            panel2.TabIndex = 2;
            // 
            // dgvResults
            // 
            dgvResults.AllowUserToAddRows = false;
            dgvResults.AllowUserToDeleteRows = false;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Columns.AddRange(new DataGridViewColumn[] { title, author });
            dgvResults.Dock = DockStyle.Fill;
            dgvResults.Location = new Point(0, 0);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.Size = new Size(499, 283);
            dgvResults.TabIndex = 0;
            // 
            // title
            // 
            title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            title.HeaderText = "Title";
            title.Name = "title";
            title.ReadOnly = true;
            // 
            // author
            // 
            author.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            author.HeaderText = "Author";
            author.Name = "author";
            author.ReadOnly = true;
            // 
            // F_ShowTransact
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 522);
            Controls.Add(panel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "F_ShowTransact";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Transaction Record";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblStuNo;
        private Label label4;
        private Label lblName;
        private Label label2;
        private Panel panel2;
        private DataGridView dgvResults;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn author;
        private Label lblDue;
        private Label label6;
        private Label lblBorrow;
        private Label label3;
    }
}