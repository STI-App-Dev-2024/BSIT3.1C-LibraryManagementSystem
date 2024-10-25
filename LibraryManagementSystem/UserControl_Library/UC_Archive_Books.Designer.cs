namespace LibraryManagementSystem.UserControl_Library
{
    partial class UC_Archive_Books
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
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            bookTitle = new DataGridViewTextBoxColumn();
            bookAuthor = new DataGridViewTextBoxColumn();
            bookDatePublished = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 70);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(895, 611);
            panel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
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
            panel3.Controls.Add(button1);
            panel3.Controls.Add(textBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(754, 65);
            panel3.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(623, 18);
            button1.Name = "button1";
            button1.Size = new Size(128, 30);
            button1.TabIndex = 1;
            button1.Text = "Filter by";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(489, 30);
            textBox1.TabIndex = 0;
            textBox1.Text = "Enter Title or Author";
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridView1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 74);
            panel4.Name = "panel4";
            panel4.Size = new Size(754, 469);
            panel4.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { bookTitle, bookAuthor, bookDatePublished });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(754, 469);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 70);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 25);
            label1.Name = "label1";
            label1.Size = new Size(135, 21);
            label1.TabIndex = 0;
            label1.Text = "Book Archive";
            // 
            // bookTitle
            // 
            bookTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bookTitle.HeaderText = "Title";
            bookTitle.Name = "bookTitle";
            bookTitle.ReadOnly = true;
            // 
            // bookAuthor
            // 
            bookAuthor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bookAuthor.HeaderText = "Author";
            bookAuthor.Name = "bookAuthor";
            bookAuthor.ReadOnly = true;
            // 
            // bookDatePublished
            // 
            bookDatePublished.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bookDatePublished.HeaderText = "Date Published";
            bookDatePublished.Name = "bookDatePublished";
            bookDatePublished.ReadOnly = true;
            // 
            // UC_Archive_Books
            // 
            AutoScaleDimensions = new SizeF(12F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "UC_Archive_Books";
            Size = new Size(895, 681);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Button button1;
        private TextBox textBox1;
        private Panel panel4;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private DataGridViewTextBoxColumn bookTitle;
        private DataGridViewTextBoxColumn bookAuthor;
        private DataGridViewTextBoxColumn bookDatePublished;
    }
}
