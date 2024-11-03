namespace LibraryManagementSystem.UserControl_Library
{
    partial class UC_CheckPreviousRecords
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
            PreviousListBox = new CheckedListBox();
            panel1 = new Panel();
            CheckrecordsTopPan = new Panel();
            SearchBox = new TextBox();
            PreviousRecordslbl = new Label();
            Filterbtn = new Button();
            panel1.SuspendLayout();
            CheckrecordsTopPan.SuspendLayout();
            SuspendLayout();
            // 
            // PreviousListBox
            // 
            PreviousListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PreviousListBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PreviousListBox.FormattingEnabled = true;
            PreviousListBox.Location = new Point(94, 217);
            PreviousListBox.Name = "PreviousListBox";
            PreviousListBox.Size = new Size(688, 424);
            PreviousListBox.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(Filterbtn);
            panel1.Controls.Add(SearchBox);
            panel1.Controls.Add(PreviousListBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 681);
            panel1.TabIndex = 1;
            // 
            // CheckrecordsTopPan
            // 
            CheckrecordsTopPan.Controls.Add(PreviousRecordslbl);
            CheckrecordsTopPan.Dock = DockStyle.Top;
            CheckrecordsTopPan.Location = new Point(0, 0);
            CheckrecordsTopPan.Name = "CheckrecordsTopPan";
            CheckrecordsTopPan.Size = new Size(895, 142);
            CheckrecordsTopPan.TabIndex = 2;
            // 
            // SearchBox
            // 
            SearchBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SearchBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBox.Location = new Point(94, 159);
            SearchBox.Multiline = true;
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(407, 41);
            SearchBox.TabIndex = 1;
            SearchBox.Text = "Search records";
            // 
            // PreviousRecordslbl
            // 
            PreviousRecordslbl.AutoSize = true;
            PreviousRecordslbl.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            PreviousRecordslbl.Location = new Point(44, 68);
            PreviousRecordslbl.Name = "PreviousRecordslbl";
            PreviousRecordslbl.Size = new Size(214, 30);
            PreviousRecordslbl.TabIndex = 0;
            PreviousRecordslbl.Text = "Previous Records List";
            // 
            // Filterbtn
            // 
            Filterbtn.Anchor = AnchorStyles.None;
            Filterbtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Filterbtn.Location = new Point(628, 159);
            Filterbtn.Name = "Filterbtn";
            Filterbtn.Size = new Size(154, 41);
            Filterbtn.TabIndex = 2;
            Filterbtn.Text = "Filter by";
            Filterbtn.UseVisualStyleBackColor = true;
            // 
            // UC_CheckPreviousRecords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CheckrecordsTopPan);
            Controls.Add(panel1);
            Name = "UC_CheckPreviousRecords";
            Size = new Size(895, 681);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            CheckrecordsTopPan.ResumeLayout(false);
            CheckrecordsTopPan.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox PreviousListBox;
        private Panel panel1;
        private Panel CheckrecordsTopPan;
        private TextBox SearchBox;
        private Label PreviousRecordslbl;
        private Button Filterbtn;
    }
}
