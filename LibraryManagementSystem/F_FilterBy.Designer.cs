namespace LibraryManagementSystem
{
    partial class F_FilterBy
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
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            radOntime = new RadioButton();
            radOngoing = new RadioButton();
            radOverdue = new RadioButton();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            radOneday = new RadioButton();
            radOneweek = new RadioButton();
            radOnemonth = new RadioButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnFilter = new Button();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 120);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Transaction Status";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(radOntime, 0, 1);
            tableLayoutPanel1.Controls.Add(radOngoing, 0, 0);
            tableLayoutPanel1.Controls.Add(radOverdue, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 29);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(401, 88);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // radOntime
            // 
            radOntime.AutoSize = true;
            radOntime.Dock = DockStyle.Fill;
            radOntime.Location = new Point(3, 47);
            radOntime.Name = "radOntime";
            radOntime.Size = new Size(194, 38);
            radOntime.TabIndex = 2;
            radOntime.TabStop = true;
            radOntime.Text = "On Time";
            radOntime.TextAlign = ContentAlignment.MiddleCenter;
            radOntime.UseVisualStyleBackColor = true;
            // 
            // radOngoing
            // 
            radOngoing.AutoSize = true;
            radOngoing.Dock = DockStyle.Fill;
            radOngoing.Location = new Point(3, 3);
            radOngoing.Name = "radOngoing";
            radOngoing.Size = new Size(194, 38);
            radOngoing.TabIndex = 0;
            radOngoing.TabStop = true;
            radOngoing.Text = "On-Going";
            radOngoing.TextAlign = ContentAlignment.MiddleCenter;
            radOngoing.UseVisualStyleBackColor = true;
            // 
            // radOverdue
            // 
            radOverdue.AutoSize = true;
            radOverdue.Dock = DockStyle.Fill;
            radOverdue.Location = new Point(203, 3);
            radOverdue.Name = "radOverdue";
            radOverdue.Size = new Size(195, 38);
            radOverdue.TabIndex = 1;
            radOverdue.TabStop = true;
            radOverdue.Text = "Overdue";
            radOverdue.TextAlign = ContentAlignment.MiddleCenter;
            radOverdue.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel2);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 120);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(407, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sort by date";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(radOneday, 0, 0);
            tableLayoutPanel2.Controls.Add(radOneweek, 1, 0);
            tableLayoutPanel2.Controls.Add(radOnemonth, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 29);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(401, 68);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // radOneday
            // 
            radOneday.AutoSize = true;
            radOneday.Dock = DockStyle.Fill;
            radOneday.Location = new Point(3, 3);
            radOneday.Name = "radOneday";
            radOneday.Size = new Size(127, 62);
            radOneday.TabIndex = 0;
            radOneday.TabStop = true;
            radOneday.Text = "1 Day";
            radOneday.UseVisualStyleBackColor = true;
            // 
            // radOneweek
            // 
            radOneweek.AutoSize = true;
            radOneweek.Dock = DockStyle.Fill;
            radOneweek.Location = new Point(136, 3);
            radOneweek.Name = "radOneweek";
            radOneweek.Size = new Size(127, 62);
            radOneweek.TabIndex = 1;
            radOneweek.TabStop = true;
            radOneweek.Text = "1 Week";
            radOneweek.UseVisualStyleBackColor = true;
            // 
            // radOnemonth
            // 
            radOnemonth.AutoSize = true;
            radOnemonth.Dock = DockStyle.Fill;
            radOnemonth.Location = new Point(269, 3);
            radOnemonth.Name = "radOnemonth";
            radOnemonth.Size = new Size(129, 62);
            radOnemonth.TabIndex = 2;
            radOnemonth.TabStop = true;
            radOnemonth.Text = "1 Month";
            radOnemonth.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Controls.Add(btnFilter, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Bottom;
            tableLayoutPanel3.Location = new Point(0, 226);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(407, 53);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // btnFilter
            // 
            btnFilter.Dock = DockStyle.Fill;
            btnFilter.Location = new Point(84, 3);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(238, 47);
            btnFilter.TabIndex = 0;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // F_FilterBy
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(407, 279);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "F_FilterBy";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Filter and Sort";
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private RadioButton radOngoing;
        private RadioButton radOverdue;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private RadioButton radOneday;
        private RadioButton radOneweek;
        private RadioButton radOnemonth;
        private RadioButton radOntime;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnFilter;
    }
}