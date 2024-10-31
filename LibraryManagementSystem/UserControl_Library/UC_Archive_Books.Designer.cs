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
            BookArchPanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            Filterbtn = new Button();
            searchBtxt = new TextBox();
            panel4 = new Panel();
            BookArchGrid = new DataGridView();
            bookTitle = new DataGridViewTextBoxColumn();
            bookAuthor = new DataGridViewTextBoxColumn();
            bookDatePublished = new DataGridViewTextBoxColumn();
            SystemPanel = new Panel();
            label1 = new Label();
            BookArchPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BookArchGrid).BeginInit();
            SystemPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BookArchPanel
            // 
            BookArchPanel.Controls.Add(tableLayoutPanel1);
            BookArchPanel.Dock = DockStyle.Fill;
            BookArchPanel.Location = new Point(0, 70);
            BookArchPanel.Margin = new Padding(0);
            BookArchPanel.Name = "BookArchPanel";
            BookArchPanel.Size = new Size(895, 611);
            BookArchPanel.TabIndex = 3;
            BookArchPanel.Paint += panel2_Paint;
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
            searchBtxt.Text = "Enter Title or Author";
            // 
            // panel4
            // 
            panel4.Controls.Add(BookArchGrid);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 74);
            panel4.Name = "panel4";
            panel4.Size = new Size(754, 469);
            panel4.TabIndex = 1;
            // 
            // BookArchGrid
            // 
            BookArchGrid.AllowUserToAddRows = false;
            BookArchGrid.AllowUserToDeleteRows = false;
            BookArchGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookArchGrid.Columns.AddRange(new DataGridViewColumn[] { bookTitle, bookAuthor, bookDatePublished });
            BookArchGrid.Dock = DockStyle.Fill;
            BookArchGrid.Location = new Point(0, 0);
            BookArchGrid.Name = "BookArchGrid";
            BookArchGrid.ReadOnly = true;
            BookArchGrid.Size = new Size(754, 469);
            BookArchGrid.TabIndex = 0;
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
            // SystemPanel
            // 
            SystemPanel.Controls.Add(label1);
            SystemPanel.Dock = DockStyle.Top;
            SystemPanel.Location = new Point(0, 0);
            SystemPanel.Name = "SystemPanel";
            SystemPanel.Size = new Size(895, 70);
            SystemPanel.TabIndex = 2;
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
            // UC_Archive_Books
            // 
            AutoScaleDimensions = new SizeF(12F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BookArchPanel);
            Controls.Add(SystemPanel);
            Font = new Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "UC_Archive_Books";
            Size = new Size(895, 681);
            BookArchPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BookArchGrid).EndInit();
            SystemPanel.ResumeLayout(false);
            SystemPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel BookArchPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Button Filterbtn;
        private TextBox searchBtxt;
        private Panel panel4;
        private DataGridView BookArchGrid;
        private Panel SystemPanel;
        private Label label1;
        private DataGridViewTextBoxColumn bookTitle;
        private DataGridViewTextBoxColumn bookAuthor;
        private DataGridViewTextBoxColumn bookDatePublished;
    }
}
