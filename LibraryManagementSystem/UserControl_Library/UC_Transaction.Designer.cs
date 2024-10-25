namespace LibraryManagementSystem.UserControl_Library
{
    partial class UC_Transaction
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
            btn_Checkout = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txt_StuNo = new TextBox();
            txt_Fullname = new TextBox();
            txt_Email = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            YearPublished = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_Checkout
            // 
            btn_Checkout.Anchor = AnchorStyles.None;
            btn_Checkout.Font = new Font("Bookman Old Style", 14F);
            btn_Checkout.Location = new Point(307, 586);
            btn_Checkout.Margin = new Padding(4);
            btn_Checkout.Name = "btn_Checkout";
            btn_Checkout.Size = new Size(258, 52);
            btn_Checkout.TabIndex = 16;
            btn_Checkout.Text = "Checkout";
            btn_Checkout.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 14F);
            label4.Location = new Point(448, 54);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(166, 21);
            label4.TabIndex = 15;
            label4.Text = "Student Number";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 14F);
            label3.Location = new Point(255, 141);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(145, 21);
            label3.TabIndex = 14;
            label3.Text = "Student Email";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 14F);
            label2.Location = new Point(77, 54);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 21);
            label2.TabIndex = 13;
            label2.Text = "Full Name";
            // 
            // txt_StuNo
            // 
            txt_StuNo.Anchor = AnchorStyles.None;
            txt_StuNo.Font = new Font("Bookman Old Style", 14F);
            txt_StuNo.Location = new Point(448, 78);
            txt_StuNo.Margin = new Padding(4);
            txt_StuNo.Name = "txt_StuNo";
            txt_StuNo.Size = new Size(389, 29);
            txt_StuNo.TabIndex = 12;
            // 
            // txt_Fullname
            // 
            txt_Fullname.Anchor = AnchorStyles.None;
            txt_Fullname.Font = new Font("Bookman Old Style", 14F);
            txt_Fullname.Location = new Point(77, 78);
            txt_Fullname.Margin = new Padding(4);
            txt_Fullname.Name = "txt_Fullname";
            txt_Fullname.Size = new Size(363, 29);
            txt_Fullname.TabIndex = 11;
            // 
            // txt_Email
            // 
            txt_Email.Anchor = AnchorStyles.None;
            txt_Email.Font = new Font("Bookman Old Style", 14F);
            txt_Email.Location = new Point(255, 165);
            txt_Email.Margin = new Padding(4);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(361, 29);
            txt_Email.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 14F);
            label1.Location = new Point(77, 230);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 9;
            label1.Text = "Books";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Title, Author, YearPublished });
            dataGridView1.Location = new Point(77, 254);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(760, 310);
            dataGridView1.TabIndex = 17;
            // 
            // Title
            // 
            Title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Title.HeaderText = "Title";
            Title.MinimumWidth = 10;
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.Resizable = DataGridViewTriState.False;
            // 
            // Author
            // 
            Author.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Author.HeaderText = "Author";
            Author.MinimumWidth = 10;
            Author.Name = "Author";
            Author.ReadOnly = true;
            // 
            // YearPublished
            // 
            YearPublished.HeaderText = "Year Published";
            YearPublished.MinimumWidth = 10;
            YearPublished.Name = "YearPublished";
            YearPublished.ReadOnly = true;
            // 
            // UC_Transaction
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(btn_Checkout);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_StuNo);
            Controls.Add(txt_Fullname);
            Controls.Add(txt_Email);
            Controls.Add(label1);
            Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "UC_Transaction";
            Size = new Size(895, 681);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Checkout;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_StuNo;
        private TextBox txt_Fullname;
        private TextBox txt_Email;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn YearPublished;
    }
}
