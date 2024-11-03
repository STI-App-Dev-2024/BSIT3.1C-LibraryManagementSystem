namespace LibraryManagementSystem.UserControl_Library
{
    partial class UC_Books
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
            btn_Search = new Button();
            grid_Inventory = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            txt_SearchBar = new TextBox();
            btn_DelBook = new Button();
            ButtonContainerPanel = new Panel();
            AddEditDeleteButtonPanel = new TableLayoutPanel();
            btn_AddBook = new Button();
            btn_EditBook = new Button();
            ContentCointainerPanel = new Panel();
            SearchButtonPanel = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)grid_Inventory).BeginInit();
            ButtonContainerPanel.SuspendLayout();
            AddEditDeleteButtonPanel.SuspendLayout();
            ContentCointainerPanel.SuspendLayout();
            SearchButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Search
            // 
            btn_Search.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_Search.Font = new Font("Microsoft Sans Serif", 14.25F);
            btn_Search.Location = new Point(650, 9);
            btn_Search.Margin = new Padding(5);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(205, 34);
            btn_Search.TabIndex = 58;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = true;
            // 
            // grid_Inventory
            // 
            grid_Inventory.AllowUserToAddRows = false;
            grid_Inventory.AllowUserToDeleteRows = false;
            grid_Inventory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grid_Inventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_Inventory.Columns.AddRange(new DataGridViewColumn[] { Title, Author, Category });
            grid_Inventory.Location = new Point(10, 70);
            grid_Inventory.Margin = new Padding(4);
            grid_Inventory.Name = "grid_Inventory";
            grid_Inventory.ReadOnly = true;
            grid_Inventory.Size = new Size(860, 448);
            grid_Inventory.TabIndex = 57;
            grid_Inventory.CellContentClick += grid_Inventory_CellContentClick;
            // 
            // Title
            // 
            Title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Title.HeaderText = "Title";
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // Author
            // 
            Author.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Author.HeaderText = "Author";
            Author.Name = "Author";
            Author.ReadOnly = true;
            // 
            // Category
            // 
            Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Category.HeaderText = "Category";
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // txt_SearchBar
            // 
            txt_SearchBar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_SearchBar.Font = new Font("Microsoft Sans Serif", 14.25F);
            txt_SearchBar.Location = new Point(5, 10);
            txt_SearchBar.Margin = new Padding(5);
            txt_SearchBar.Multiline = true;
            txt_SearchBar.Name = "txt_SearchBar";
            txt_SearchBar.Size = new Size(635, 32);
            txt_SearchBar.TabIndex = 56;
            txt_SearchBar.Text = "Search Book Title";
            // 
            // btn_DelBook
            // 
            btn_DelBook.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_DelBook.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_DelBook.Location = new Point(576, 32);
            btn_DelBook.Margin = new Padding(5);
            btn_DelBook.Name = "btn_DelBook";
            btn_DelBook.Size = new Size(274, 64);
            btn_DelBook.TabIndex = 55;
            btn_DelBook.Text = "Delete Book";
            btn_DelBook.UseVisualStyleBackColor = true;
            // 
            // ButtonContainerPanel
            // 
            ButtonContainerPanel.Controls.Add(AddEditDeleteButtonPanel);
            ButtonContainerPanel.Dock = DockStyle.Top;
            ButtonContainerPanel.Location = new Point(0, 0);
            ButtonContainerPanel.Margin = new Padding(3, 10, 3, 3);
            ButtonContainerPanel.Name = "ButtonContainerPanel";
            ButtonContainerPanel.Padding = new Padding(10);
            ButtonContainerPanel.Size = new Size(880, 152);
            ButtonContainerPanel.TabIndex = 59;
            // 
            // AddEditDeleteButtonPanel
            // 
            AddEditDeleteButtonPanel.ColumnCount = 3;
            AddEditDeleteButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            AddEditDeleteButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            AddEditDeleteButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            AddEditDeleteButtonPanel.Controls.Add(btn_AddBook, 0, 0);
            AddEditDeleteButtonPanel.Controls.Add(btn_DelBook, 2, 0);
            AddEditDeleteButtonPanel.Controls.Add(btn_EditBook, 1, 0);
            AddEditDeleteButtonPanel.Dock = DockStyle.Top;
            AddEditDeleteButtonPanel.Location = new Point(10, 10);
            AddEditDeleteButtonPanel.Name = "AddEditDeleteButtonPanel";
            AddEditDeleteButtonPanel.Padding = new Padding(5);
            AddEditDeleteButtonPanel.RowCount = 1;
            AddEditDeleteButtonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            AddEditDeleteButtonPanel.Size = new Size(860, 129);
            AddEditDeleteButtonPanel.TabIndex = 56;
            // 
            // btn_AddBook
            // 
            btn_AddBook.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_AddBook.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_AddBook.ForeColor = Color.Black;
            btn_AddBook.Location = new Point(10, 32);
            btn_AddBook.Margin = new Padding(5);
            btn_AddBook.Name = "btn_AddBook";
            btn_AddBook.Size = new Size(273, 64);
            btn_AddBook.TabIndex = 53;
            btn_AddBook.Text = "Add Book";
            btn_AddBook.UseVisualStyleBackColor = true;
            // 
            // btn_EditBook
            // 
            btn_EditBook.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_EditBook.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_EditBook.Location = new Point(293, 32);
            btn_EditBook.Margin = new Padding(5);
            btn_EditBook.Name = "btn_EditBook";
            btn_EditBook.Size = new Size(273, 64);
            btn_EditBook.TabIndex = 54;
            btn_EditBook.Text = "Edit Book";
            btn_EditBook.UseVisualStyleBackColor = true;
            // 
            // ContentCointainerPanel
            // 
            ContentCointainerPanel.Controls.Add(grid_Inventory);
            ContentCointainerPanel.Controls.Add(SearchButtonPanel);
            ContentCointainerPanel.Dock = DockStyle.Fill;
            ContentCointainerPanel.Location = new Point(0, 152);
            ContentCointainerPanel.Name = "ContentCointainerPanel";
            ContentCointainerPanel.Padding = new Padding(10);
            ContentCointainerPanel.Size = new Size(880, 528);
            ContentCointainerPanel.TabIndex = 60;
            // 
            // SearchButtonPanel
            // 
            SearchButtonPanel.ColumnCount = 2;
            SearchButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            SearchButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            SearchButtonPanel.Controls.Add(btn_Search, 1, 0);
            SearchButtonPanel.Controls.Add(txt_SearchBar, 0, 0);
            SearchButtonPanel.Dock = DockStyle.Top;
            SearchButtonPanel.Location = new Point(10, 10);
            SearchButtonPanel.Name = "SearchButtonPanel";
            SearchButtonPanel.RowCount = 1;
            SearchButtonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            SearchButtonPanel.Size = new Size(860, 53);
            SearchButtonPanel.TabIndex = 59;
            // 
            // UC_Books
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ContentCointainerPanel);
            Controls.Add(ButtonContainerPanel);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "UC_Books";
            Size = new Size(880, 680);
            ((System.ComponentModel.ISupportInitialize)grid_Inventory).EndInit();
            ButtonContainerPanel.ResumeLayout(false);
            AddEditDeleteButtonPanel.ResumeLayout(false);
            ContentCointainerPanel.ResumeLayout(false);
            SearchButtonPanel.ResumeLayout(false);
            SearchButtonPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Search;
        private DataGridView grid_Inventory;
        private TextBox txt_SearchBar;
        private Button btn_DelBook;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Category;
        private Panel ButtonContainerPanel;
        private Panel ContentCointainerPanel;
        private Button btn_AddBook;
        private Button btn_EditBook;
        private TableLayoutPanel AddEditDeleteButtonPanel;
        private TableLayoutPanel SearchButtonPanel;
    }
}
