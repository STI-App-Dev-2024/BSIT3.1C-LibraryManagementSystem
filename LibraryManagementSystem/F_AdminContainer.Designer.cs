namespace LibraryManagementSystem
{
    partial class F_AdminContainer
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
            panelOver = new Panel();
            SuspendLayout();
            // 
            // panelOver
            // 
            panelOver.Dock = DockStyle.Fill;
            panelOver.Location = new Point(0, 0);
            panelOver.Name = "panelOver";
            panelOver.Size = new Size(1264, 718);
            panelOver.TabIndex = 0;
            // 
            // F_AdminContainer
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 718);
            Controls.Add(panelOver);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "F_AdminContainer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F_AdminContainer";
            WindowState = FormWindowState.Maximized;
            FormClosing += F_AdminContainer_FormClosing;
            Load += F_AdminContainer_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelOver;
    }
}