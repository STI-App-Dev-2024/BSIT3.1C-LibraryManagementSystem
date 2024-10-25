namespace LibraryManagementSystem.UserControl_Library
{
    partial class UC_Dashboard
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            Category = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            label7 = new Label();
            textBox1 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 2, 0);
            tableLayoutPanel1.Location = new Point(110, 70);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(657, 147);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 141);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 105);
            label2.Margin = new Padding(3, 0, 3, 15);
            label2.Name = "label2";
            label2.Size = new Size(180, 21);
            label2.TabIndex = 1;
            label2.Text = "Student Borrowed";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 69);
            label1.Margin = new Padding(3, 0, 3, 15);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 0;
            label1.Text = "100";
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(222, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(213, 141);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 105);
            label3.Margin = new Padding(3, 0, 3, 15);
            label3.Name = "label3";
            label3.Size = new Size(175, 21);
            label3.TabIndex = 1;
            label3.Text = "Nearing Due Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 69);
            label4.Margin = new Padding(3, 0, 3, 15);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 0;
            label4.Text = "100";
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(441, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(213, 141);
            panel3.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 105);
            label5.Margin = new Padding(3, 0, 3, 15);
            label5.Name = "label5";
            label5.Size = new Size(180, 21);
            label5.TabIndex = 1;
            label5.Text = "Overdue Students";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 69);
            label6.Margin = new Padding(3, 0, 3, 15);
            label6.Name = "label6";
            label6.Size = new Size(46, 21);
            label6.TabIndex = 0;
            label6.Text = "100";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Category, Title });
            dataGridView1.Location = new Point(45, 332);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(797, 302);
            dataGridView1.TabIndex = 1;
            // 
            // Category
            // 
            Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Category.HeaderText = "Category";
            Category.Name = "Category";
            // 
            // Title
            // 
            Title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Title.HeaderText = "Title";
            Title.Name = "Title";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(45, 308);
            label7.Name = "label7";
            label7.Size = new Size(162, 23);
            label7.TabIndex = 2;
            label7.Text = "Available Books";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(474, 296);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 30);
            textBox1.TabIndex = 3;
            textBox1.Text = "Search Book";
            // 
            // UC_Dashboard
            // 
            AutoScaleDimensions = new SizeF(12F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "UC_Dashboard";
            Size = new Size(895, 681);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Panel panel3;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Title;
        private Label label7;
        private TextBox textBox1;
    }
}
