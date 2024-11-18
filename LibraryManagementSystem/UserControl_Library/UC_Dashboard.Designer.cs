namespace LibraryManagementSystem.UserControl_Library
{
    partial class UC_Dashboard
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
            DashboardStatusPanel = new TableLayoutPanel();
            StudentBorrowedPanel = new Panel();
            label2 = new Label();
            label1 = new Label();
            NearDueDatePanel = new Panel();
            label3 = new Label();
            label4 = new Label();
            OverdueStudentsPanel = new Panel();
            label5 = new Label();
            label6 = new Label();
            DataGridViewBookAvailable = new DataGridView();
            Category = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            DBUpperContentPanel = new Panel();
            AvailableBooksPanel = new Panel();
            AvailableBookLabel = new Label();
            AvailableBookSearch = new TextBox();
            DBMiddleContentContainerPanel = new TableLayoutPanel();
            AvailableBookLabelPanel = new Panel();
            AvailableBookSearchPanel = new Panel();
            DataGridViewAvailableContainerPanel = new Panel();
            DashboardStatusPanel.SuspendLayout();
            StudentBorrowedPanel.SuspendLayout();
            NearDueDatePanel.SuspendLayout();
            OverdueStudentsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewBookAvailable).BeginInit();
            DBUpperContentPanel.SuspendLayout();
            DBMiddleContentContainerPanel.SuspendLayout();
            AvailableBookLabelPanel.SuspendLayout();
            AvailableBookSearchPanel.SuspendLayout();
            DataGridViewAvailableContainerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // DashboardStatusPanel
            // 
            DashboardStatusPanel.Anchor = AnchorStyles.None;
            DashboardStatusPanel.AutoSize = true;
            DashboardStatusPanel.ColumnCount = 3;
            DashboardStatusPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            DashboardStatusPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            DashboardStatusPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            DashboardStatusPanel.Controls.Add(StudentBorrowedPanel, 0, 0);
            DashboardStatusPanel.Controls.Add(NearDueDatePanel, 1, 0);
            DashboardStatusPanel.Controls.Add(OverdueStudentsPanel, 2, 0);
            DashboardStatusPanel.Location = new Point(96, 24);
            DashboardStatusPanel.Margin = new Padding(5);
            DashboardStatusPanel.Name = "DashboardStatusPanel";
            DashboardStatusPanel.Padding = new Padding(5);
            DashboardStatusPanel.RowCount = 1;
            DashboardStatusPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            DashboardStatusPanel.Size = new Size(697, 161);
            DashboardStatusPanel.TabIndex = 0;
            DashboardStatusPanel.Paint += tableLayoutPanel1_Paint;
            // 
            // StudentBorrowedPanel
            // 
            StudentBorrowedPanel.BackColor = Color.FromArgb(128, 255, 128);
            StudentBorrowedPanel.Controls.Add(label2);
            StudentBorrowedPanel.Controls.Add(label1);
            StudentBorrowedPanel.Dock = DockStyle.Fill;
            StudentBorrowedPanel.Location = new Point(8, 8);
            StudentBorrowedPanel.Name = "StudentBorrowedPanel";
            StudentBorrowedPanel.Size = new Size(223, 145);
            StudentBorrowedPanel.TabIndex = 0;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(0, 84);
            label2.Margin = new Padding(3, 0, 3, 15);
            label2.Name = "label2";
            label2.Size = new Size(223, 61);
            label2.TabIndex = 1;
            label2.Text = "Student Borrowed";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(3, 0, 3, 15);
            label1.Name = "label1";
            label1.Size = new Size(223, 130);
            label1.TabIndex = 0;
            label1.Text = "100";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NearDueDatePanel
            // 
            NearDueDatePanel.BackColor = Color.FromArgb(255, 255, 192);
            NearDueDatePanel.Controls.Add(label3);
            NearDueDatePanel.Controls.Add(label4);
            NearDueDatePanel.Dock = DockStyle.Fill;
            NearDueDatePanel.Location = new Point(237, 8);
            NearDueDatePanel.Name = "NearDueDatePanel";
            NearDueDatePanel.Size = new Size(223, 145);
            NearDueDatePanel.TabIndex = 0;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(0, 84);
            label3.Margin = new Padding(3, 0, 3, 15);
            label3.Name = "label3";
            label3.Size = new Size(223, 61);
            label3.TabIndex = 1;
            label3.Text = "Due Today";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(3, 0, 3, 15);
            label4.Name = "label4";
            label4.Size = new Size(223, 130);
            label4.TabIndex = 0;
            label4.Text = "100";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OverdueStudentsPanel
            // 
            OverdueStudentsPanel.BackColor = Color.FromArgb(255, 128, 128);
            OverdueStudentsPanel.Controls.Add(label5);
            OverdueStudentsPanel.Controls.Add(label6);
            OverdueStudentsPanel.Dock = DockStyle.Fill;
            OverdueStudentsPanel.Location = new Point(468, 10);
            OverdueStudentsPanel.Margin = new Padding(5);
            OverdueStudentsPanel.Name = "OverdueStudentsPanel";
            OverdueStudentsPanel.Padding = new Padding(5);
            OverdueStudentsPanel.Size = new Size(219, 141);
            OverdueStudentsPanel.TabIndex = 0;
            OverdueStudentsPanel.Paint += panel3_Paint;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Bottom;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(5, 82);
            label5.Margin = new Padding(3, 0, 3, 15);
            label5.Name = "label5";
            label5.Size = new Size(209, 54);
            label5.TabIndex = 1;
            label5.Text = "Overdue Students";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI", 14.25F);
            label6.Location = new Point(5, 5);
            label6.Margin = new Padding(3, 0, 3, 15);
            label6.Name = "label6";
            label6.Size = new Size(209, 123);
            label6.TabIndex = 0;
            label6.Text = "100";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DataGridViewBookAvailable
            // 
            DataGridViewBookAvailable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewBookAvailable.Columns.AddRange(new DataGridViewColumn[] { Category, Title });
            DataGridViewBookAvailable.Dock = DockStyle.Fill;
            DataGridViewBookAvailable.Location = new Point(0, 0);
            DataGridViewBookAvailable.Margin = new Padding(0);
            DataGridViewBookAvailable.Name = "DataGridViewBookAvailable";
            DataGridViewBookAvailable.Size = new Size(895, 437);
            DataGridViewBookAvailable.TabIndex = 1;
            // 
            // Category
            // 
            Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Category.HeaderText = "Category";
            Category.Name = "Category";
            // 
            // Title
            // 
            Title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Title.HeaderText = "Title";
            Title.Name = "Title";
            // 
            // DBUpperContentPanel
            // 
            DBUpperContentPanel.AutoSize = true;
            DBUpperContentPanel.Controls.Add(DashboardStatusPanel);
            DBUpperContentPanel.Dock = DockStyle.Top;
            DBUpperContentPanel.Location = new Point(0, 0);
            DBUpperContentPanel.Name = "DBUpperContentPanel";
            DBUpperContentPanel.Size = new Size(895, 190);
            DBUpperContentPanel.TabIndex = 4;
            // 
            // AvailableBooksPanel
            // 
            AvailableBooksPanel.AutoSize = true;
            AvailableBooksPanel.Dock = DockStyle.Bottom;
            AvailableBooksPanel.Location = new Point(0, 681);
            AvailableBooksPanel.Name = "AvailableBooksPanel";
            AvailableBooksPanel.Size = new Size(895, 0);
            AvailableBooksPanel.TabIndex = 6;
            // 
            // AvailableBookLabel
            // 
            AvailableBookLabel.Anchor = AnchorStyles.None;
            AvailableBookLabel.AutoSize = true;
            AvailableBookLabel.Font = new Font("Segoe UI", 14.25F);
            AvailableBookLabel.Location = new Point(5, 15);
            AvailableBookLabel.Name = "AvailableBookLabel";
            AvailableBookLabel.Size = new Size(144, 25);
            AvailableBookLabel.TabIndex = 2;
            AvailableBookLabel.Text = "Available Books";
            // 
            // AvailableBookSearch
            // 
            AvailableBookSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AvailableBookSearch.Font = new Font("Segoe UI", 14.25F);
            AvailableBookSearch.Location = new Point(4, 12);
            AvailableBookSearch.Multiline = true;
            AvailableBookSearch.Name = "AvailableBookSearch";
            AvailableBookSearch.Size = new Size(411, 29);
            AvailableBookSearch.TabIndex = 3;
            AvailableBookSearch.Text = "Search Book";
            // 
            // DBMiddleContentContainerPanel
            // 
            DBMiddleContentContainerPanel.ColumnCount = 2;
            DBMiddleContentContainerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.08099F));
            DBMiddleContentContainerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.91901F));
            DBMiddleContentContainerPanel.Controls.Add(AvailableBookLabelPanel, 0, 0);
            DBMiddleContentContainerPanel.Controls.Add(AvailableBookSearchPanel, 1, 0);
            DBMiddleContentContainerPanel.Dock = DockStyle.Top;
            DBMiddleContentContainerPanel.Location = new Point(0, 190);
            DBMiddleContentContainerPanel.Margin = new Padding(5, 5, 5, 0);
            DBMiddleContentContainerPanel.Name = "DBMiddleContentContainerPanel";
            DBMiddleContentContainerPanel.Padding = new Padding(5, 5, 5, 0);
            DBMiddleContentContainerPanel.RowCount = 1;
            DBMiddleContentContainerPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            DBMiddleContentContainerPanel.Size = new Size(895, 54);
            DBMiddleContentContainerPanel.TabIndex = 7;
            // 
            // AvailableBookLabelPanel
            // 
            AvailableBookLabelPanel.Anchor = AnchorStyles.Left;
            AvailableBookLabelPanel.Controls.Add(AvailableBookLabel);
            AvailableBookLabelPanel.Location = new Point(8, 8);
            AvailableBookLabelPanel.Name = "AvailableBookLabelPanel";
            AvailableBookLabelPanel.Size = new Size(454, 43);
            AvailableBookLabelPanel.TabIndex = 0;
            // 
            // AvailableBookSearchPanel
            // 
            AvailableBookSearchPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AvailableBookSearchPanel.Controls.Add(AvailableBookSearch);
            AvailableBookSearchPanel.Location = new Point(468, 8);
            AvailableBookSearchPanel.Name = "AvailableBookSearchPanel";
            AvailableBookSearchPanel.Size = new Size(419, 43);
            AvailableBookSearchPanel.TabIndex = 1;
            // 
            // DataGridViewAvailableContainerPanel
            // 
            DataGridViewAvailableContainerPanel.Controls.Add(DataGridViewBookAvailable);
            DataGridViewAvailableContainerPanel.Dock = DockStyle.Fill;
            DataGridViewAvailableContainerPanel.Location = new Point(0, 244);
            DataGridViewAvailableContainerPanel.Name = "DataGridViewAvailableContainerPanel";
            DataGridViewAvailableContainerPanel.Size = new Size(895, 437);
            DataGridViewAvailableContainerPanel.TabIndex = 8;
            // 
            // UC_Dashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DataGridViewAvailableContainerPanel);
            Controls.Add(AvailableBooksPanel);
            Controls.Add(DBMiddleContentContainerPanel);
            Controls.Add(DBUpperContentPanel);
            Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "UC_Dashboard";
            Size = new Size(895, 681);
            DashboardStatusPanel.ResumeLayout(false);
            StudentBorrowedPanel.ResumeLayout(false);
            NearDueDatePanel.ResumeLayout(false);
            OverdueStudentsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewBookAvailable).EndInit();
            DBUpperContentPanel.ResumeLayout(false);
            DBUpperContentPanel.PerformLayout();
            DBMiddleContentContainerPanel.ResumeLayout(false);
            AvailableBookLabelPanel.ResumeLayout(false);
            AvailableBookLabelPanel.PerformLayout();
            AvailableBookSearchPanel.ResumeLayout(false);
            AvailableBookSearchPanel.PerformLayout();
            DataGridViewAvailableContainerPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel DashboardStatusPanel;
        private Panel StudentBorrowedPanel;
        private Label label2;
        private Label label1;
        private Panel NearDueDatePanel;
        private Label label3;
        private Label label4;
        private Panel OverdueStudentsPanel;
        private Label label5;
        private Label label6;
        private DataGridView DataGridViewBookAvailable;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Title;
        private Panel DBUpperContentPanel;
        private Panel AvailableBooksPanel;
        private Label AvailableBookLabel;
        private TextBox AvailableBookSearch;
        private TableLayoutPanel DBMiddleContentContainerPanel;
        private Panel AvailableBookLabelPanel;
        private Panel AvailableBookSearchPanel;
        private Panel DataGridViewAvailableContainerPanel;
    }
}
