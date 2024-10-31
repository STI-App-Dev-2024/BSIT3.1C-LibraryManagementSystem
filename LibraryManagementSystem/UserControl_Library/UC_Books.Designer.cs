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
            btn_EditBook = new Button();
            btn_AddBook = new Button();
            ButtonsPanel = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)grid_Inventory).BeginInit();
            ButtonsPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Search
            // 
            btn_Search.Font = new Font("Bookman Old Style", 14.25F);
            btn_Search.Location = new Point(566, 55);
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
            grid_Inventory.Location = new Point(79, 96);
            grid_Inventory.Margin = new Padding(4);
            grid_Inventory.Name = "grid_Inventory";
            grid_Inventory.ReadOnly = true;
            grid_Inventory.Size = new Size(741, 376);
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
            txt_SearchBar.Anchor = AnchorStyles.None;
            txt_SearchBar.Font = new Font("Bookman Old Style", 14.25F);
            txt_SearchBar.Location = new Point(79, 57);
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
            btn_DelBook.Location = new Point(566, 37);
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
            btn_EditBook.Location = new Point(317, 37);
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
            btn_AddBook.ForeColor = Color.Black;
            btn_AddBook.Location = new Point(63, 37);
            btn_AddBook.Margin = new Padding(5);
            btn_AddBook.Name = "btn_AddBook";
            btn_AddBook.Size = new Size(244, 64);
            btn_AddBook.TabIndex = 53;
            btn_AddBook.Text = "Add Book";
            btn_AddBook.UseVisualStyleBackColor = true;
            // 
            // ButtonsPanel
            // 
            ButtonsPanel.Controls.Add(btn_DelBook);
            ButtonsPanel.Controls.Add(btn_EditBook);
            ButtonsPanel.Controls.Add(btn_AddBook);
            ButtonsPanel.Dock = DockStyle.Top;
            ButtonsPanel.Location = new Point(0, 0);
            ButtonsPanel.Margin = new Padding(3, 10, 3, 3);
            ButtonsPanel.Name = "ButtonsPanel";
            ButtonsPanel.Size = new Size(895, 154);
            ButtonsPanel.TabIndex = 59;
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_SearchBar);
            panel1.Controls.Add(grid_Inventory);
            panel1.Controls.Add(btn_Search);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 160);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 521);
            panel1.TabIndex = 60;
            // 
            // UC_Books
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ButtonsPanel);
            Controls.Add(panel1);
            Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "UC_Books";
            Size = new Size(895, 681);
            ((System.ComponentModel.ISupportInitialize)grid_Inventory).EndInit();
            ButtonsPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Panel ButtonsPanel;
        private Panel panel1;
    }
}
