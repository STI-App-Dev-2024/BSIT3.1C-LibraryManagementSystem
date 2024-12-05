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
            BookArchGrid = new DataGridView();
            BookArchiveSearchAndFilterPanel = new TableLayoutPanel();
            searchBtxt = new TextBox();
            SystemPanel = new Panel();
            label1 = new Label();
            bookTitle = new DataGridViewTextBoxColumn();
            bookAuthor = new DataGridViewTextBoxColumn();
            publisher = new DataGridViewTextBoxColumn();
            bookDatePublished = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            BookArchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BookArchGrid).BeginInit();
            BookArchiveSearchAndFilterPanel.SuspendLayout();
            SystemPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BookArchPanel
            // 
            BookArchPanel.Controls.Add(BookArchGrid);
            BookArchPanel.Controls.Add(BookArchiveSearchAndFilterPanel);
            BookArchPanel.Dock = DockStyle.Fill;
            BookArchPanel.Location = new Point(0, 99);
            BookArchPanel.Margin = new Padding(0);
            BookArchPanel.Name = "BookArchPanel";
            BookArchPanel.Size = new Size(880, 581);
            BookArchPanel.TabIndex = 3;
            BookArchPanel.Paint += panel2_Paint;
            // 
            // BookArchGrid
            // 
            BookArchGrid.AllowUserToAddRows = false;
            BookArchGrid.AllowUserToDeleteRows = false;
            BookArchGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookArchGrid.Columns.AddRange(new DataGridViewColumn[] { bookTitle, bookAuthor, publisher, bookDatePublished, category });
            BookArchGrid.Dock = DockStyle.Fill;
            BookArchGrid.Location = new Point(0, 51);
            BookArchGrid.Name = "BookArchGrid";
            BookArchGrid.ReadOnly = true;
            BookArchGrid.Size = new Size(880, 530);
            BookArchGrid.TabIndex = 0;
            // 
            // BookArchiveSearchAndFilterPanel
            // 
            BookArchiveSearchAndFilterPanel.ColumnCount = 1;
            BookArchiveSearchAndFilterPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.2800446F));
            BookArchiveSearchAndFilterPanel.Controls.Add(searchBtxt, 0, 0);
            BookArchiveSearchAndFilterPanel.Dock = DockStyle.Top;
            BookArchiveSearchAndFilterPanel.Location = new Point(0, 0);
            BookArchiveSearchAndFilterPanel.Name = "BookArchiveSearchAndFilterPanel";
            BookArchiveSearchAndFilterPanel.RowCount = 1;
            BookArchiveSearchAndFilterPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            BookArchiveSearchAndFilterPanel.Size = new Size(880, 51);
            BookArchiveSearchAndFilterPanel.TabIndex = 2;
            // 
            // searchBtxt
            // 
            searchBtxt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            searchBtxt.Font = new Font("Segoe UI", 14.25F);
            searchBtxt.Location = new Point(3, 11);
            searchBtxt.Multiline = true;
            searchBtxt.Name = "searchBtxt";
            searchBtxt.Size = new Size(874, 29);
            searchBtxt.TabIndex = 0;
            searchBtxt.Text = "Enter Title or Author";
            // 
            // SystemPanel
            // 
            SystemPanel.Controls.Add(label1);
            SystemPanel.Dock = DockStyle.Top;
            SystemPanel.Location = new Point(0, 0);
            SystemPanel.Name = "SystemPanel";
            SystemPanel.Size = new Size(880, 99);
            SystemPanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(880, 96);
            label1.TabIndex = 0;
            label1.Text = "Book Archive";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            // publisher
            // 
            publisher.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            publisher.HeaderText = "Publisher";
            publisher.Name = "publisher";
            publisher.ReadOnly = true;
            // 
            // bookDatePublished
            // 
            bookDatePublished.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bookDatePublished.HeaderText = "Year Published";
            bookDatePublished.Name = "bookDatePublished";
            bookDatePublished.ReadOnly = true;
            // 
            // category
            // 
            category.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            category.HeaderText = "Category";
            category.Name = "category";
            category.ReadOnly = true;
            // 
            // UC_Archive_Books
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BookArchPanel);
            Controls.Add(SystemPanel);
            Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "UC_Archive_Books";
            Size = new Size(880, 680);
            BookArchPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BookArchGrid).EndInit();
            BookArchiveSearchAndFilterPanel.ResumeLayout(false);
            BookArchiveSearchAndFilterPanel.PerformLayout();
            SystemPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel BookArchPanel;
        private TextBox searchBtxt;
        private Panel SystemPanel;
        private Label label1;
        private TableLayoutPanel BookArchiveSearchAndFilterPanel;
        private DataGridView BookArchGrid;
        private DataGridViewTextBoxColumn bookTitle;
        private DataGridViewTextBoxColumn bookAuthor;
        private DataGridViewTextBoxColumn publisher;
        private DataGridViewTextBoxColumn bookDatePublished;
        private DataGridViewTextBoxColumn category;
    }
}
