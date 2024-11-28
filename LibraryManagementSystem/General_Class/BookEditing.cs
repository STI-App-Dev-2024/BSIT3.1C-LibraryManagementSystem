using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.General_Class
{
    internal class BookEditing
    {
        MySqlConnection connection;
        MySqlCommand cmd;

        string conn = "server=localhost;uid=root;password=password;database=librarymanagement";
        public void EditBook(string[] records, int[] copies, int id)
        {
            try
            {
                connection = new MySqlConnection(conn);
                connection.Open();

                string query = "UPDATE books " +
                        "SET barcode = @barcode, title = @title, author = @author, publisher = @publisher," +
                        "year_published = @year, isbn = @isbn, category = @category, edition = @edition," +
                        "updated_at = NOW() " +
                        "WHERE book_id = @id";
                cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@barcode", records[0]);
                cmd.Parameters.AddWithValue("@title", records[1]);
                cmd.Parameters.AddWithValue("@author", records[2]);
                cmd.Parameters.AddWithValue("@publisher", records[3]);
                cmd.Parameters.AddWithValue("@year", Convert.ToInt32(records[4]));
                cmd.Parameters.AddWithValue("@isbn", records[5]);
                cmd.Parameters.AddWithValue("@category", records[6]);
                cmd.Parameters.AddWithValue("@edition", records[7]);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                EditCopy(copies[1], copies[0], id);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void EditCopy(int copy, int initial, int id)
        {
            try
            {
                if (copy > initial)
                {
                    for (int i = initial; i < copy; i++)
                    {
                        string accessionNumber = $"A{id:D4}{i:D4}";
                        string query = "INSERT INTO copies(book_id, accession_number, status, created_by, updated_by) " +
                        "VALUES(@id, @number, @status, NOW(), NOW())";
                        cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@number", accessionNumber);
                        cmd.Parameters.AddWithValue("@status", "Available");

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
