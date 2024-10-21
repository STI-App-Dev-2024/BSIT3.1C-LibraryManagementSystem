namespace LibraryManagementSystem
{
    partial class UserControlArchive
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
            Search = new TextBox();
            label1 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // Search
            // 
            Search.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Search.Location = new Point(105, 149);
            Search.Multiline = true;
            Search.Name = "Search";
            Search.Size = new Size(766, 41);
            Search.TabIndex = 0;
            Search.Text = "Search Student Number or BookId";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 19);
            label1.Name = "label1";
            label1.Size = new Size(358, 37);
            label1.TabIndex = 1;
            label1.Text = "Student Transaction History";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 37;
            listBox1.Location = new Point(68, 216);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1450, 559);
            listBox1.TabIndex = 2;
            // 
            // UserControlArchive
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(Search);
            Name = "UserControlArchive";
            Size = new Size(1600, 900);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Search;
        private Label label1;
        private ListBox listBox1;
    }
}
