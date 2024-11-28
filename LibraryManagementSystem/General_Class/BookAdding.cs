using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.General_Class
{
    internal class BookAdding
    {
        MySqlConnection connection;
        MySqlCommand cmd;

        string conn = "server=localhost;uid=root;password=password;database=librarymanagement";
        //FOR ADDING BOOK
        public void addBook(string[] record)
        {
            try
            {
                connection = new MySqlConnection(conn);
                connection.Open();
                string query = "INSERT INTO books(barcode, title, author, publisher, year_published, isbn, category, edition, created_at, updated_at)" +
                    " VALUES(@bar, @title, @author, @publisher, @year, @isbn, @category, @edition, NOW(), NOW())";
                cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@bar", record[0]);
                cmd.Parameters.AddWithValue("@title", record[1]);
                cmd.Parameters.AddWithValue("@author", record[2]);
                cmd.Parameters.AddWithValue("@publisher", record[3]);
                cmd.Parameters.AddWithValue("@year", Convert.ToInt32(record[4]));
                cmd.Parameters.AddWithValue("@isbn", record[5]);
                cmd.Parameters.AddWithValue("@category", record[6].ToLower());
                cmd.Parameters.AddWithValue("@edition", record[7]);
                cmd.ExecuteNonQuery();

                addCopies(Convert.ToInt32(record[8]), Convert.ToInt64(record[0]));
                MessageBox.Show("Book added Successfully!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void addCopies(int copy, long id)
        {
            try
            {
                string query1 = "SELECT book_id FROM books WHERE barcode = @bar";
                cmd = new MySqlCommand(query1, connection);
                cmd.Parameters.AddWithValue("@bar", id.ToString());
                int bookid = (int)cmd.ExecuteScalar();

                for (int i = 0; i < copy; i++)
                {
                    string accessionNumber = $"A{bookid:D4}{i:D4}";
                    string query = "INSERT INTO copies(book_id, accession_number, status, created_by, updated_by) VALUES(@id, @number, @status, NOW(), NOW())";
                    cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", bookid);
                    cmd.Parameters.AddWithValue("@number", accessionNumber);
                    cmd.Parameters.AddWithValue("@status", "Available");

                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
