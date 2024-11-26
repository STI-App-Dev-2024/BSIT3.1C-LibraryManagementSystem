using LibraryManagementSystem.General_Class;
using MySql.Data.MySqlClient;
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
    public partial class F_AddForm : Form
    {
        SqlConnection connect = new SqlConnection();
        public F_AddForm()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            String[] record =
            {   
                txtID.Text,
                txtTitle.Text,
                txtAuthor.Text,
                txtPublisher.Text,
                txtYear.Text,
                txtISBN.Text,
                cbCategory.Text,
                txtEdition.Text,
                txtQuantity.Text
            };
            try
            {
                connect.addBook(record);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
