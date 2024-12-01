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
            txtEmail = new TextBox();
            StudentDetailContainerPanel = new Panel();
            StudentEmailContainerPanel = new Panel();
            StudentEmailPanel = new Panel();
            StudentNameAndNumberPanel = new TableLayoutPanel();
            StudentNamePanel = new Panel();
            txtLastName = new TextBox();
            StudentNumberPanel = new Panel();
            txtStuNo = new TextBox();
            panel1 = new Panel();
            txtFirstName = new TextBox();
            label5 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            CheckoutPanel = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btn_Checkout = new Button();
            cartGrid = new DataGridView();
            copyid = new DataGridViewTextBoxColumn();
            accessNum = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            LabelBookPanel = new Panel();
            txtBarcode = new TextBox();
            label1 = new Label();
            StudentDetailContainerPanel.SuspendLayout();
            StudentEmailContainerPanel.SuspendLayout();
            StudentEmailPanel.SuspendLayout();
            StudentNameAndNumberPanel.SuspendLayout();
            StudentNamePanel.SuspendLayout();
            StudentNumberPanel.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            CheckoutPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cartGrid).BeginInit();
            LabelBookPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(16, 10);
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
            label2.Location = new Point(16, 11);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 13;
            label2.Text = "Last Name";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Font = new Font("Segoe UI", 14.25F);
            txtEmail.Location = new Point(113, 41);
            txtEmail.Margin = new Padding(4);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(607, 43);
            txtEmail.TabIndex = 10;
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
            StudentEmailPanel.Controls.Add(txtEmail);
            StudentEmailPanel.Location = new Point(21, 16);
            StudentEmailPanel.Name = "StudentEmailPanel";
            StudentEmailPanel.Size = new Size(834, 92);
            StudentEmailPanel.TabIndex = 18;
            // 
            // StudentNameAndNumberPanel
            // 
            StudentNameAndNumberPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            StudentNameAndNumberPanel.AutoSize = true;
            StudentNameAndNumberPanel.ColumnCount = 3;
            StudentNameAndNumberPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            StudentNameAndNumberPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            StudentNameAndNumberPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            StudentNameAndNumberPanel.Controls.Add(StudentNamePanel, 0, 0);
            StudentNameAndNumberPanel.Controls.Add(StudentNumberPanel, 2, 0);
            StudentNameAndNumberPanel.Controls.Add(panel1, 1, 0);
            StudentNameAndNumberPanel.Location = new Point(3, 20);
            StudentNameAndNumberPanel.Margin = new Padding(0, 0, 5, 5);
            StudentNameAndNumberPanel.Name = "StudentNameAndNumberPanel";
            StudentNameAndNumberPanel.Padding = new Padding(0, 0, 5, 5);
            StudentNameAndNumberPanel.RowCount = 1;
            StudentNameAndNumberPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            StudentNameAndNumberPanel.Size = new Size(873, 110);
            StudentNameAndNumberPanel.TabIndex = 16;
            // 
            // StudentNamePanel
            // 
            StudentNamePanel.Controls.Add(txtLastName);
            StudentNamePanel.Controls.Add(label2);
            StudentNamePanel.Dock = DockStyle.Fill;
            StudentNamePanel.Location = new Point(5, 5);
            StudentNamePanel.Margin = new Padding(5);
            StudentNamePanel.Name = "StudentNamePanel";
            StudentNamePanel.Size = new Size(279, 95);
            StudentNamePanel.TabIndex = 17;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.Font = new Font("Segoe UI", 14.25F);
            txtLastName.Location = new Point(4, 39);
            txtLastName.Margin = new Padding(4);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(271, 40);
            txtLastName.TabIndex = 12;
            // 
            // StudentNumberPanel
            // 
            StudentNumberPanel.Controls.Add(txtStuNo);
            StudentNumberPanel.Controls.Add(label4);
            StudentNumberPanel.Dock = DockStyle.Fill;
            StudentNumberPanel.Location = new Point(583, 5);
            StudentNumberPanel.Margin = new Padding(5);
            StudentNumberPanel.Name = "StudentNumberPanel";
            StudentNumberPanel.Size = new Size(280, 95);
            StudentNumberPanel.TabIndex = 17;
            // 
            // txtStuNo
            // 
            txtStuNo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtStuNo.Font = new Font("Segoe UI", 14.25F);
            txtStuNo.Location = new Point(4, 38);
            txtStuNo.Margin = new Padding(4);
            txtStuNo.Multiline = true;
            txtStuNo.Name = "txtStuNo";
            txtStuNo.Size = new Size(272, 41);
            txtStuNo.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(294, 5);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 95);
            panel1.TabIndex = 17;
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFirstName.Font = new Font("Segoe UI", 14.25F);
            txtFirstName.Location = new Point(4, 39);
            txtFirstName.Margin = new Padding(4);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(271, 40);
            txtFirstName.TabIndex = 12;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(16, 11);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 13;
            label5.Text = "First Name";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(CheckoutPanel, 0, 2);
            tableLayoutPanel1.Controls.Add(cartGrid, 0, 1);
            tableLayoutPanel1.Controls.Add(LabelBookPanel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 262);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(880, 418);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // CheckoutPanel
            // 
            CheckoutPanel.Controls.Add(tableLayoutPanel2);
            CheckoutPanel.Dock = DockStyle.Fill;
            CheckoutPanel.Location = new Point(3, 357);
            CheckoutPanel.Name = "CheckoutPanel";
            CheckoutPanel.Size = new Size(874, 58);
            CheckoutPanel.TabIndex = 24;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(btn_Checkout, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(874, 58);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_Checkout
            // 
            btn_Checkout.Dock = DockStyle.Fill;
            btn_Checkout.Font = new Font("Segoe UI", 14.25F);
            btn_Checkout.Location = new Point(222, 4);
            btn_Checkout.Margin = new Padding(4);
            btn_Checkout.Name = "btn_Checkout";
            btn_Checkout.Size = new Size(429, 50);
            btn_Checkout.TabIndex = 17;
            btn_Checkout.Text = "Verify and Checkout";
            btn_Checkout.UseVisualStyleBackColor = true;
            btn_Checkout.Click += btn_Checkout_Click_1;
            // 
            // cartGrid
            // 
            cartGrid.AllowUserToAddRows = false;
            cartGrid.AllowUserToDeleteRows = false;
            cartGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cartGrid.Columns.AddRange(new DataGridViewColumn[] { copyid, accessNum, Title, Author, status });
            cartGrid.Dock = DockStyle.Fill;
            cartGrid.Location = new Point(3, 44);
            cartGrid.Name = "cartGrid";
            cartGrid.ReadOnly = true;
            cartGrid.Size = new Size(874, 307);
            cartGrid.TabIndex = 23;
            cartGrid.CellContentClick += cartGrid_CellContentClick;
            // 
            // copyid
            // 
            copyid.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            copyid.HeaderText = "Copy ID";
            copyid.Name = "copyid";
            copyid.ReadOnly = true;
            copyid.Width = 75;
            // 
            // accessNum
            // 
            accessNum.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            accessNum.HeaderText = "Accession Number";
            accessNum.Name = "accessNum";
            accessNum.ReadOnly = true;
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
            // status
            // 
            status.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            status.HeaderText = "Status";
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // LabelBookPanel
            // 
            LabelBookPanel.AutoSize = true;
            LabelBookPanel.Controls.Add(txtBarcode);
            LabelBookPanel.Controls.Add(label1);
            LabelBookPanel.Dock = DockStyle.Fill;
            LabelBookPanel.Location = new Point(3, 3);
            LabelBookPanel.Name = "LabelBookPanel";
            LabelBookPanel.Size = new Size(874, 35);
            LabelBookPanel.TabIndex = 22;
            // 
            // txtBarcode
            // 
            txtBarcode.Dock = DockStyle.Right;
            txtBarcode.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBarcode.Location = new Point(559, 0);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(315, 29);
            txtBarcode.TabIndex = 10;
            txtBarcode.KeyDown += txtBarcode_KeyDown_1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(185, 35);
            label1.TabIndex = 9;
            label1.Text = "Books";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UC_Transaction
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
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
            StudentNamePanel.ResumeLayout(false);
            StudentNamePanel.PerformLayout();
            StudentNumberPanel.ResumeLayout(false);
            StudentNumberPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            CheckoutPanel.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cartGrid).EndInit();
            LabelBookPanel.ResumeLayout(false);
            LabelBookPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtEmail;
        private Panel StudentDetailContainerPanel;
        private TextBox txtLastName;
        private TextBox txtStuNo;
        private TableLayoutPanel StudentNameAndNumberPanel;
        private Panel StudentNamePanel;
        private Panel StudentNumberPanel;
        private Panel StudentEmailContainerPanel;
        private Panel StudentEmailPanel;
        private Panel panel1;
        private TextBox txtFirstName;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel LabelBookPanel;
        private TextBox txtBarcode;
        private Label label1;
        private DataGridView cartGrid;
        private DataGridViewTextBoxColumn copyid;
        private DataGridViewTextBoxColumn accessNum;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn status;
        private Panel CheckoutPanel;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btn_Checkout;
    }
}
