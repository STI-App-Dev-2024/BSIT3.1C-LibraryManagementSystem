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
    public partial class F_EditForm : Form
    {
        private int bookID;
        private int copy_initial;

        MySqlConnection connection;
        MySqlCommand cmd;
        BookEditing edit = new BookEditing();
        _forComboBox combo;

        string conn = "server=localhost;uid=root;password=password;database=librarymanagement";
        public F_EditForm(int id)
        {
            InitializeComponent();
            this.bookID = id;
            getBook();
            combo = new _forComboBox(cbCategory);
        }

        private void getBook()
        {
            try
            {
                connection = new MySqlConnection(conn);
                connection.Open();

                string query = "SELECT * FROM books WHERE book_id = @id";
                cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", bookID);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtID.Text = reader["barcode"].ToString();
                    txtTitle.Text = reader["title"].ToString();
                    txtAuthor.Text = reader["author"].ToString();
                    txtPublisher.Text = reader["publisher"].ToString();
                    txtYear.Text = reader["year_published"].ToString();
                    txtISBN.Text = reader["isbn"].ToString();
                    cbCategory.Text = reader["category"].ToString();
                    txtEdition.Text = reader["edition"].ToString();
                    txtQuantity.Text = GetCopy().ToString();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private long GetCopy()
        {
            long copy = 0;
            try
            {
                connection = new MySqlConnection(conn);
                connection.Open();
                string query = "SELECT COUNT(*) FROM copies WHERE book_id = @id";
                cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", bookID);

                copy = (long)cmd.ExecuteScalar();
                copy_initial = (int) copy;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return copy;
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            string[] input =
            {
                txtID.Text,
                txtTitle.Text,
                txtAuthor.Text,
                txtPublisher.Text,
                txtYear.Text,
                txtISBN.Text,
                cbCategory.SelectedItem.ToString(),
                txtEdition.Text
            };
            int[] copies = {copy_initial, Convert.ToInt32(txtQuantity.Text) };
            edit.EditBook(input, copies, bookID);
            MessageBox.Show("Update success!");
            this.Close();
        }
    }
}
