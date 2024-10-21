namespace LibraryManagementSystem
{
    partial class UserControlBookInventory
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            checkedListBox1 = new CheckedListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(308, 93);
            button1.Name = "button1";
            button1.Size = new Size(171, 46);
            button1.TabIndex = 0;
            button1.Text = "Add Book";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(649, 93);
            button2.Name = "button2";
            button2.Size = new Size(167, 46);
            button2.TabIndex = 1;
            button2.Text = "Edit Book";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(1002, 93);
            button3.Name = "button3";
            button3.Size = new Size(169, 46);
            button3.TabIndex = 2;
            button3.Text = "Edit Book";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(299, 185);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(669, 50);
            textBox1.TabIndex = 50;
            textBox1.Text = "Search Book Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(236, 298);
            label1.Name = "label1";
            label1.Size = new Size(128, 37);
            label1.TabIndex = 51;
            label1.Text = "Book List";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(590, 298);
            label2.Name = "label2";
            label2.Size = new Size(139, 37);
            label2.TabIndex = 52;
            label2.Text = "Book Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(970, 298);
            label3.Name = "label3";
            label3.Size = new Size(103, 37);
            label3.TabIndex = 53;
            label3.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1258, 298);
            label4.Name = "label4";
            label4.Size = new Size(90, 37);
            label4.TabIndex = 54;
            label4.Text = "Genre";
            // 
            // checkedListBox1
            // 
            checkedListBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Int || Book - 1234 || Author || Genre", " " });
            checkedListBox1.Location = new Point(124, 353);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(1319, 490);
            checkedListBox1.TabIndex = 55;
            // 
            // UserControlBookInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(checkedListBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "UserControlBookInventory";
            Size = new Size(1600, 900);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckedListBox checkedListBox1;
    }
}
