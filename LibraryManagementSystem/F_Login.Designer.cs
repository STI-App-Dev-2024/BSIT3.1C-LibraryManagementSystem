namespace LibraryManagementSystem
{
    partial class F_Login
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
            panelLogin = new Panel();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.Location = new Point(0, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(664, 366);
            panelLogin.TabIndex = 0;
            // 
            // F_Login
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 366);
            Controls.Add(panelLogin);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            MaximumSize = new Size(680, 405);
            MinimumSize = new Size(680, 405);
            Name = "F_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Please Login First";
            Load += F_Login_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
    }
}