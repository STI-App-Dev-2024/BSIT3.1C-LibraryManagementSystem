using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class F_FilterBy : Form
    {
        public F_FilterBy()
        {
            InitializeComponent();
        }

        public string getFilter()
        {
            string statusFilter = "";
            if (radOngoing.Checked)
            {
                statusFilter = "t.status = 'On-Going'";
            }
            else if (radOntime.Checked)
            {
                statusFilter = "t.status = 'On-time'";
            }
            else if (radOverdue.Checked)
            {
                statusFilter = "t.status = 'Overdue'";
            }

            string dateFilter = "";
            if (radOneday.Checked)
            {
                dateFilter = "t.borrow_date >= DATE_ADD(NOW(), INTERVAL -1 DAY)";
            }
            else if (radOneweek.Checked)
            {
                dateFilter = "t.borrow_date >= DATE_ADD(NOW(), INTERVAL -1 WEEK)";
            }
            else if (radOnemonth.Checked)
            {
                dateFilter = "t.borrow_date >= DATE_ADD(NOW(), INTERVAL -1 MONTH)";
            }

            string filterQuery = "";
            if (!string.IsNullOrEmpty(statusFilter) && !string.IsNullOrEmpty(dateFilter))
            {
                filterQuery = $"{statusFilter} AND {dateFilter}";
            }
            else if (!string.IsNullOrEmpty(statusFilter))
            {
                filterQuery = statusFilter;
            }
            else if (!string.IsNullOrEmpty(dateFilter))
            {
                filterQuery = dateFilter;
            }

            return filterQuery;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
