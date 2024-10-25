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
            txt_SearchBar = new TextBox();
            btn_DelBook = new Button();
            btn_EditBook = new Button();
            btn_AddBook = new Button();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)grid_Inventory).BeginInit();
            SuspendLayout();
            // 
            // btn_Search
            // 
            btn_Search.Font = new Font("Bookman Old Style", 14.25F);
            btn_Search.Location = new Point(578, 221);
            btn_Search.Margin = new Padding(5);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(241, 30);
            btn_Search.TabIndex = 58;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = true;
            // 
            // grid_Inventory
            // 
            grid_Inventory.AllowUserToAddRows = false;
            grid_Inventory.AllowUserToDeleteRows = false;
            grid_Inventory.Anchor = AnchorStyles.None;
            grid_Inventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_Inventory.Columns.AddRange(new DataGridViewColumn[] { Title, Author, Category });
            grid_Inventory.Location = new Point(78, 260);
            grid_Inventory.Margin = new Padding(4);
            grid_Inventory.Name = "grid_Inventory";
            grid_Inventory.ReadOnly = true;
            grid_Inventory.Size = new Size(741, 348);
            grid_Inventory.TabIndex = 57;
            // 
            // txt_SearchBar
            // 
            txt_SearchBar.Anchor = AnchorStyles.None;
            txt_SearchBar.Font = new Font("Bookman Old Style", 14.25F);
            txt_SearchBar.Location = new Point(78, 221);
            txt_SearchBar.Margin = new Padding(5);
            txt_SearchBar.Name = "txt_SearchBar";
            txt_SearchBar.Size = new Size(473, 30);
            txt_SearchBar.TabIndex = 56;
            txt_SearchBar.Text = "Search Book Title";
            // 
            // btn_DelBook
            // 
            btn_DelBook.Anchor = AnchorStyles.None;
            btn_DelBook.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            btn_DelBook.Location = new Point(578, 72);
            btn_DelBook.Margin = new Padding(5);
            btn_DelBook.Name = "btn_DelBook";
            btn_DelBook.Size = new Size(241, 64);
            btn_DelBook.TabIndex = 55;
            btn_DelBook.Text = "Delete Book";
            btn_DelBook.UseVisualStyleBackColor = true;
            // 
            // btn_EditBook
            // 
            btn_EditBook.Anchor = AnchorStyles.None;
            btn_EditBook.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            btn_EditBook.Location = new Point(329, 72);
            btn_EditBook.Margin = new Padding(5);
            btn_EditBook.Name = "btn_EditBook";
            btn_EditBook.Size = new Size(239, 64);
            btn_EditBook.TabIndex = 54;
            btn_EditBook.Text = "Edit Book";
            btn_EditBook.UseVisualStyleBackColor = true;
            // 
            // btn_AddBook
            // 
            btn_AddBook.Anchor = AnchorStyles.None;
            btn_AddBook.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            btn_AddBook.Location = new Point(75, 72);
            btn_AddBook.Margin = new Padding(5);
            btn_AddBook.Name = "btn_AddBook";
            btn_AddBook.Size = new Size(244, 64);
            btn_AddBook.TabIndex = 53;
            btn_AddBook.Text = "Add Book";
            btn_AddBook.UseVisualStyleBackColor = true;
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
            // UC_Books
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_Search);
            Controls.Add(grid_Inventory);
            Controls.Add(txt_SearchBar);
            Controls.Add(btn_DelBook);
            Controls.Add(btn_EditBook);
            Controls.Add(btn_AddBook);
            Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "UC_Books";
            Size = new Size(895, 681);
            ((System.ComponentModel.ISupportInitialize)grid_Inventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Search;
        private DataGridView grid_Inventory;
        private TextBox txt_SearchBar;
        private Button btn_DelBook;
        private Button btn_EditBook;
        private Button btn_AddBook;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Category;
    }
}
