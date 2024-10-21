namespace LibraryManagementSystem
{
    partial class FormAdminArchives
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
            Search = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Search
            // 
            Search.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Search.Location = new Point(92, 66);
            Search.Multiline = true;
            Search.Name = "Search";
            Search.Size = new Size(803, 41);
            Search.TabIndex = 2;
            Search.Text = "Search Student No or BookID";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 37;
            listBox1.Location = new Point(92, 124);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1180, 485);
            listBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(92, 654);
            button1.Name = "button1";
            button1.Size = new Size(254, 46);
            button1.TabIndex = 11;
            button1.Text = "Return";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormAdminArchives
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(Search);
            Name = "FormAdminArchives";
            Text = "FormAdminArchives";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Search;
        private ListBox listBox1;
        private Button button1;
    }
}