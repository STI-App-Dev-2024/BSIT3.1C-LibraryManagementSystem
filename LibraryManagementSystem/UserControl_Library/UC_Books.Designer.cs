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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Books));
            btn_Search = new Button();
            grid_Inventory = new DataGridView();
            txt_SearchBar = new TextBox();
            ButtonContainerPanel = new Panel();
            AddEditDeleteButtonPanel = new TableLayoutPanel();
            btn_AddBook = new Button();
            ContentCointainerPanel = new Panel();
            SearchButtonPanel = new TableLayoutPanel();
            bookID = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            edit = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
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
            btn_Search.Font = new Font("Segoe UI", 14.25F);
            btn_Search.Location = new Point(650, 9);
            btn_Search.Margin = new Padding(5);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(205, 34);
            btn_Search.TabIndex = 58;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // grid_Inventory
            // 
            grid_Inventory.AllowUserToAddRows = false;
            grid_Inventory.AllowUserToDeleteRows = false;
            grid_Inventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_Inventory.Columns.AddRange(new DataGridViewColumn[] { bookID, Title, Author, edit, delete });
            grid_Inventory.Dock = DockStyle.Fill;
            grid_Inventory.Location = new Point(10, 63);
            grid_Inventory.Margin = new Padding(4);
            grid_Inventory.Name = "grid_Inventory";
            grid_Inventory.ReadOnly = true;
            grid_Inventory.Size = new Size(860, 455);
            grid_Inventory.TabIndex = 57;
            grid_Inventory.CellClick += grid_Inventory_CellClick;
            grid_Inventory.CellContentClick += grid_Inventory_CellContentClick;
            // 
            // txt_SearchBar
            // 
            txt_SearchBar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_SearchBar.Font = new Font("Segoe UI", 14.25F);
            txt_SearchBar.Location = new Point(5, 10);
            txt_SearchBar.Margin = new Padding(5);
            txt_SearchBar.Multiline = true;
            txt_SearchBar.Name = "txt_SearchBar";
            txt_SearchBar.Size = new Size(635, 32);
            txt_SearchBar.TabIndex = 56;
            txt_SearchBar.Text = "Search Book Title";
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
            btn_AddBook.Font = new Font("Segoe UI", 14.25F);
            btn_AddBook.ForeColor = Color.Black;
            btn_AddBook.Image = (Image)resources.GetObject("btn_AddBook.Image");
            btn_AddBook.ImageAlign = ContentAlignment.MiddleLeft;
            btn_AddBook.Location = new Point(10, 32);
            btn_AddBook.Margin = new Padding(5);
            btn_AddBook.Name = "btn_AddBook";
            btn_AddBook.Size = new Size(273, 64);
            btn_AddBook.TabIndex = 53;
            btn_AddBook.Text = "Add Book";
            btn_AddBook.UseVisualStyleBackColor = true;
            btn_AddBook.Click += btn_AddBook_Click;
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
            // bookID
            // 
            bookID.HeaderText = "Book ID";
            bookID.Name = "bookID";
            bookID.ReadOnly = true;
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
            // edit
            // 
            edit.HeaderText = "Edit?";
            edit.Name = "edit";
            edit.ReadOnly = true;
            edit.Text = "EDIT";
            edit.UseColumnTextForButtonValue = true;
            // 
            // delete
            // 
            delete.HeaderText = "Archive?";
            delete.Name = "delete";
            delete.ReadOnly = true;
            delete.Text = "ARCHIVE";
            delete.UseColumnTextForButtonValue = true;
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
        private Panel ButtonContainerPanel;
        private Panel ContentCointainerPanel;
        private Button btn_AddBook;
        private TableLayoutPanel AddEditDeleteButtonPanel;
        private TableLayoutPanel SearchButtonPanel;
        private DataGridViewTextBoxColumn bookID;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn delete;
    }
}
