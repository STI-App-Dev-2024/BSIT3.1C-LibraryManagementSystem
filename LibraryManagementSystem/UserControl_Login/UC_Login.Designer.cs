namespace LibraryManagementSystem.UserControl_Login
{
    partial class UC_Login
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            panel3 = new Panel();
            btnLogin = new Button();
            linkReset = new LinkLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(664, 90);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(664, 90);
            label1.TabIndex = 0;
            label1.Text = "Library Management System Login";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtEmail);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(664, 136);
            panel2.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(150, 88);
            txtPassword.Margin = new Padding(150, 3, 150, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(364, 33);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 49);
            txtEmail.Margin = new Padding(150, 3, 150, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(364, 33);
            txtEmail.TabIndex = 0;
            txtEmail.Text = "Email";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnLogin);
            panel3.Controls.Add(linkReset);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 226);
            panel3.Name = "panel3";
            panel3.Size = new Size(664, 92);
            panel3.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(150, 49);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(364, 40);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // linkReset
            // 
            linkReset.AutoSize = true;
            linkReset.Location = new Point(303, 3);
            linkReset.Name = "linkReset";
            linkReset.Size = new Size(211, 25);
            linkReset.TabIndex = 0;
            linkReset.TabStop = true;
            linkReset.Text = "Reset Password Request";
            linkReset.LinkClicked += linkLabel1_LinkClicked;
            // 
            // UC_Login
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "UC_Login";
            Size = new Size(664, 366);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Panel panel3;
        private Button btnLogin;
        private LinkLabel linkReset;
    }
}
