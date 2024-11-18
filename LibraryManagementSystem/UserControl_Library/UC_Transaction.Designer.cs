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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txt_Email = new TextBox();
            label1 = new Label();
            StudentDetailContainerPanel = new Panel();
            StudentEmailContainerPanel = new Panel();
            StudentEmailPanel = new Panel();
            StudentNameAndNumberPanel = new TableLayoutPanel();
            StudentNumberPanel = new Panel();
            txt_Fullname = new TextBox();
            StudentNamePanel = new Panel();
            txt_StuNo = new TextBox();
            btn_Checkout = new Button();
            dataGridView1 = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            YearPublished = new DataGridViewTextBoxColumn();
            TransactionContentPanel = new Panel();
            LabelBookPanel = new Panel();
            CheckoutPanel = new Panel();
            ScannedBookPanel = new Panel();
            StudentDetailContainerPanel.SuspendLayout();
            StudentEmailContainerPanel.SuspendLayout();
            StudentEmailPanel.SuspendLayout();
            StudentNameAndNumberPanel.SuspendLayout();
            StudentNumberPanel.SuspendLayout();
            StudentNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            TransactionContentPanel.SuspendLayout();
            LabelBookPanel.SuspendLayout();
            CheckoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(16, 6);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(150, 25);
            label4.TabIndex = 15;
            label4.Text = "Student Number";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(127, 13);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 14;
            label3.Text = "Student Email";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(16, 5);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 13;
            label2.Text = "Full Name";
            // 
            // txt_Email
            // 
            txt_Email.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_Email.Font = new Font("Segoe UI", 14.25F);
            txt_Email.Location = new Point(113, 41);
            txt_Email.Margin = new Padding(4);
            txt_Email.Multiline = true;
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(607, 43);
            txt_Email.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(14, 4);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 9;
            label1.Text = "Books";
            label1.Click += label1_Click;
            // 
            // StudentDetailContainerPanel
            // 
            StudentDetailContainerPanel.AutoSize = true;
            StudentDetailContainerPanel.Controls.Add(StudentEmailContainerPanel);
            StudentDetailContainerPanel.Controls.Add(StudentNameAndNumberPanel);
            StudentDetailContainerPanel.Dock = DockStyle.Top;
            StudentDetailContainerPanel.Location = new Point(0, 0);
            StudentDetailContainerPanel.Name = "StudentDetailContainerPanel";
            StudentDetailContainerPanel.Size = new Size(880, 262);
            StudentDetailContainerPanel.TabIndex = 19;
            // 
            // StudentEmailContainerPanel
            // 
            StudentEmailContainerPanel.Anchor = AnchorStyles.None;
            StudentEmailContainerPanel.AutoSize = true;
            StudentEmailContainerPanel.Controls.Add(StudentEmailPanel);
            StudentEmailContainerPanel.Location = new Point(3, 137);
            StudentEmailContainerPanel.Margin = new Padding(5);
            StudentEmailContainerPanel.Name = "StudentEmailContainerPanel";
            StudentEmailContainerPanel.Padding = new Padding(5);
            StudentEmailContainerPanel.Size = new Size(873, 120);
            StudentEmailContainerPanel.TabIndex = 17;
            // 
            // StudentEmailPanel
            // 
            StudentEmailPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            StudentEmailPanel.Controls.Add(label3);
            StudentEmailPanel.Controls.Add(txt_Email);
            StudentEmailPanel.Location = new Point(21, 16);
            StudentEmailPanel.Name = "StudentEmailPanel";
            StudentEmailPanel.Size = new Size(834, 92);
            StudentEmailPanel.TabIndex = 18;
            // 
            // StudentNameAndNumberPanel
            // 
            StudentNameAndNumberPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            StudentNameAndNumberPanel.AutoSize = true;
            StudentNameAndNumberPanel.ColumnCount = 2;
            StudentNameAndNumberPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StudentNameAndNumberPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            StudentNameAndNumberPanel.Controls.Add(StudentNumberPanel, 1, 0);
            StudentNameAndNumberPanel.Controls.Add(StudentNamePanel, 0, 0);
            StudentNameAndNumberPanel.Location = new Point(3, 20);
            StudentNameAndNumberPanel.Margin = new Padding(0, 0, 5, 5);
            StudentNameAndNumberPanel.Name = "StudentNameAndNumberPanel";
            StudentNameAndNumberPanel.Padding = new Padding(0, 0, 5, 5);
            StudentNameAndNumberPanel.RowCount = 1;
            StudentNameAndNumberPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            StudentNameAndNumberPanel.Size = new Size(873, 110);
            StudentNameAndNumberPanel.TabIndex = 16;
            // 
            // StudentNumberPanel
            // 
            StudentNumberPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            StudentNumberPanel.Controls.Add(txt_Fullname);
            StudentNumberPanel.Controls.Add(label4);
            StudentNumberPanel.Location = new Point(439, 9);
            StudentNumberPanel.Margin = new Padding(5);
            StudentNumberPanel.Name = "StudentNumberPanel";
            StudentNumberPanel.Size = new Size(424, 86);
            StudentNumberPanel.TabIndex = 17;
            // 
            // txt_Fullname
            // 
            txt_Fullname.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_Fullname.Font = new Font("Segoe UI", 14.25F);
            txt_Fullname.Location = new Point(4, 34);
            txt_Fullname.Margin = new Padding(4);
            txt_Fullname.Multiline = true;
            txt_Fullname.Name = "txt_Fullname";
            txt_Fullname.Size = new Size(416, 41);
            txt_Fullname.TabIndex = 11;
            // 
            // StudentNamePanel
            // 
            StudentNamePanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            StudentNamePanel.Controls.Add(txt_StuNo);
            StudentNamePanel.Controls.Add(label2);
            StudentNamePanel.Location = new Point(5, 11);
            StudentNamePanel.Margin = new Padding(5);
            StudentNamePanel.Name = "StudentNamePanel";
            StudentNamePanel.Size = new Size(424, 83);
            StudentNamePanel.TabIndex = 17;
            // 
            // txt_StuNo
            // 
            txt_StuNo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_StuNo.Font = new Font("Segoe UI", 14.25F);
            txt_StuNo.Location = new Point(4, 33);
            txt_StuNo.Margin = new Padding(4);
            txt_StuNo.Multiline = true;
            txt_StuNo.Name = "txt_StuNo";
            txt_StuNo.Size = new Size(416, 40);
            txt_StuNo.TabIndex = 12;
            // 
            // btn_Checkout
            // 
            btn_Checkout.Anchor = AnchorStyles.None;
            btn_Checkout.Font = new Font("Segoe UI", 14.25F);
            btn_Checkout.Location = new Point(341, 10);
            btn_Checkout.Margin = new Padding(4);
            btn_Checkout.Name = "btn_Checkout";
            btn_Checkout.Size = new Size(215, 37);
            btn_Checkout.TabIndex = 16;
            btn_Checkout.Text = "Checkout";
            btn_Checkout.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Title, Author, YearPublished });
            dataGridView1.Location = new Point(27, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(828, 280);
            dataGridView1.TabIndex = 17;
            // 
            // Title
            // 
            Title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Title.FillWeight = 51.54639F;
            Title.HeaderText = "Title";
            Title.MinimumWidth = 10;
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.Resizable = DataGridViewTriState.False;
            // 
            // Author
            // 
            Author.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Author.FillWeight = 148.453613F;
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
            // TransactionContentPanel
            // 
            TransactionContentPanel.AutoSize = true;
            TransactionContentPanel.Controls.Add(LabelBookPanel);
            TransactionContentPanel.Controls.Add(CheckoutPanel);
            TransactionContentPanel.Controls.Add(dataGridView1);
            TransactionContentPanel.Controls.Add(ScannedBookPanel);
            TransactionContentPanel.Dock = DockStyle.Fill;
            TransactionContentPanel.Location = new Point(0, 262);
            TransactionContentPanel.Name = "TransactionContentPanel";
            TransactionContentPanel.Size = new Size(880, 418);
            TransactionContentPanel.TabIndex = 20;
            // 
            // LabelBookPanel
            // 
            LabelBookPanel.AutoSize = true;
            LabelBookPanel.Controls.Add(label1);
            LabelBookPanel.Location = new Point(24, 19);
            LabelBookPanel.Name = "LabelBookPanel";
            LabelBookPanel.Size = new Size(834, 37);
            LabelBookPanel.TabIndex = 18;
            // 
            // CheckoutPanel
            // 
            CheckoutPanel.Controls.Add(btn_Checkout);
            CheckoutPanel.Dock = DockStyle.Bottom;
            CheckoutPanel.Location = new Point(0, 359);
            CheckoutPanel.Name = "CheckoutPanel";
            CheckoutPanel.Size = new Size(880, 59);
            CheckoutPanel.TabIndex = 19;
            // 
            // ScannedBookPanel
            // 
            ScannedBookPanel.Location = new Point(24, 62);
            ScannedBookPanel.Name = "ScannedBookPanel";
            ScannedBookPanel.Size = new Size(834, 348);
            ScannedBookPanel.TabIndex = 20;
            // 
            // UC_Transaction
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TransactionContentPanel);
            Controls.Add(StudentDetailContainerPanel);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "UC_Transaction";
            Size = new Size(880, 680);
            StudentDetailContainerPanel.ResumeLayout(false);
            StudentDetailContainerPanel.PerformLayout();
            StudentEmailContainerPanel.ResumeLayout(false);
            StudentEmailPanel.ResumeLayout(false);
            StudentEmailPanel.PerformLayout();
            StudentNameAndNumberPanel.ResumeLayout(false);
            StudentNumberPanel.ResumeLayout(false);
            StudentNumberPanel.PerformLayout();
            StudentNamePanel.ResumeLayout(false);
            StudentNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            TransactionContentPanel.ResumeLayout(false);
            TransactionContentPanel.PerformLayout();
            LabelBookPanel.ResumeLayout(false);
            LabelBookPanel.PerformLayout();
            CheckoutPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_Email;
        private Label label1;
        private Panel StudentDetailContainerPanel;
        private Button btn_Checkout;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn YearPublished;
        private Panel TransactionContentPanel;
        private TextBox txt_StuNo;
        private TextBox txt_Fullname;
        private TableLayoutPanel StudentNameAndNumberPanel;
        private Panel StudentNamePanel;
        private Panel StudentNumberPanel;
        private Panel StudentEmailContainerPanel;
        private Panel LabelBookPanel;
        private Panel CheckoutPanel;
        private Panel ScannedBookPanel;
        private Panel StudentEmailPanel;
    }
}
