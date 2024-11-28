namespace LibraryManagementSystem
{
    partial class F_EditForm
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
            btnAddBook = new Button();
            cbCategory = new ComboBox();
            txtQuantity = new TextBox();
            txtEdition = new TextBox();
            txtISBN = new TextBox();
            txtYear = new TextBox();
            txtPublisher = new TextBox();
            txtAuthor = new TextBox();
            txtID = new TextBox();
            txtTitle = new TextBox();
            label6 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label9 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(237, 380);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(216, 43);
            btnAddBook.TabIndex = 41;
            btnAddBook.Text = "Update book";
            btnAddBook.UseVisualStyleBackColor = true;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "Biography and Memoir", "History", "Science and Nature", "Self-Help and Personal Development", "Travel and Adventure", "Religion and Spirituality", "Cookbooks and Food", "Health and Wellness", "Technology and Programming", "STEM", "Social Sciences", "Humanities", "Business and Management", "Law and Legal Studies", "Medicine and Health Science", "Education", "Reference Materials", "Thesis", "Academic Journals" });
            cbCategory.Location = new Point(429, 208);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(226, 33);
            cbCategory.TabIndex = 40;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(581, 303);
            txtQuantity.Margin = new Padding(10);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(74, 33);
            txtQuantity.TabIndex = 38;
            // 
            // txtEdition
            // 
            txtEdition.Location = new Point(187, 303);
            txtEdition.Margin = new Padding(10);
            txtEdition.Name = "txtEdition";
            txtEdition.Size = new Size(266, 33);
            txtEdition.TabIndex = 37;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(187, 253);
            txtISBN.Margin = new Padding(10);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(468, 33);
            txtISBN.TabIndex = 36;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(187, 208);
            txtYear.Margin = new Padding(10);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(117, 33);
            txtYear.TabIndex = 35;
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(187, 163);
            txtPublisher.Margin = new Padding(10);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(468, 33);
            txtPublisher.TabIndex = 34;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(187, 118);
            txtAuthor.Margin = new Padding(10);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(468, 33);
            txtAuthor.TabIndex = 39;
            // 
            // txtID
            // 
            txtID.Location = new Point(187, 20);
            txtID.Margin = new Padding(10);
            txtID.Name = "txtID";
            txtID.Size = new Size(468, 33);
            txtID.TabIndex = 33;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(187, 73);
            txtTitle.Margin = new Padding(10);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(468, 33);
            txtTitle.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 216);
            label6.Margin = new Padding(10);
            label6.Name = "label6";
            label6.Size = new Size(140, 25);
            label6.TabIndex = 29;
            label6.Text = "Year Published:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(473, 306);
            label8.Margin = new Padding(10);
            label8.Name = "label8";
            label8.Size = new Size(88, 25);
            label8.TabIndex = 28;
            label8.Text = "Quantity:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(92, 306);
            label7.Margin = new Padding(10);
            label7.Name = "label7";
            label7.Size = new Size(75, 25);
            label7.TabIndex = 27;
            label7.Text = "Edition:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(111, 261);
            label5.Margin = new Padding(10);
            label5.Name = "label5";
            label5.Size = new Size(56, 25);
            label5.TabIndex = 26;
            label5.Text = "ISBN:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(324, 216);
            label4.Margin = new Padding(10);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 25;
            label4.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 171);
            label3.Margin = new Padding(10);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 24;
            label3.Text = "Publisher:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(133, 23);
            label9.Margin = new Padding(10);
            label9.Name = "label9";
            label9.Size = new Size(34, 25);
            label9.TabIndex = 31;
            label9.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 126);
            label2.Margin = new Padding(10);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 23;
            label2.Text = "Author:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 81);
            label1.Margin = new Padding(10);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 30;
            label1.Text = "Title:";
            // 
            // F_EditForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 443);
            Controls.Add(btnAddBook);
            Controls.Add(cbCategory);
            Controls.Add(txtQuantity);
            Controls.Add(txtEdition);
            Controls.Add(txtISBN);
            Controls.Add(txtYear);
            Controls.Add(txtPublisher);
            Controls.Add(txtAuthor);
            Controls.Add(txtID);
            Controls.Add(txtTitle);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "F_EditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddBook;
        private ComboBox cbCategory;
        private TextBox txtQuantity;
        private TextBox txtEdition;
        private TextBox txtISBN;
        private TextBox txtYear;
        private TextBox txtPublisher;
        private TextBox txtAuthor;
        private TextBox txtID;
        private TextBox txtTitle;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label9;
        private Label label2;
        private Label label1;
    }
}