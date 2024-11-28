using LibraryManagementSystem.Events;
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
        BookAdding add = new BookAdding();
        public F_AddForm()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            
            try
            {
                String[] record =
                {
                    txtID.Text,
                    txtTitle.Text,
                    txtAuthor.Text,
                    txtPublisher.Text,
                    txtYear.Text,
                    txtISBN.Text,
                    cbCategory.SelectedItem.ToString(),
                    txtEdition.Text,
                    txtQuantity.Text
                };
                add.addBook(record);
                BookNotifier._NewBookAdded();
                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
