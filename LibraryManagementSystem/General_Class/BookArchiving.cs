using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.General_Class
{
    class BookArchiving
    {
        MySqlConnection connect;
        MySqlCommand cmd;
        string conn = "server=localhost;uid=root;password=password;database=librarymanagement";

        public BookArchiving(int id)
        {
            try
            {
                connect = new MySqlConnection(conn);
                connect.Open();
                string query = "SELECT * FROM books WHERE book_id = @id";
                cmd = new MySqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string[] results =
                    {
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetInt32(5).ToString(),
                    reader.GetString(6),
                    reader.GetString(7),
                    reader.GetString(8)
                };
                    connect.Close();
                    archiving(results);
                    deleteCopies(id);
                    deleteBook(id);
                    MessageBox.Show("Archive complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void archiving(string[] results)
        {
            try
            {
                connect = new MySqlConnection(conn);
                connect.Open();
                string query = "INSERT INTO book_archive(title, author, publisher, year_published, isbn, " +
                "category, edition, created_at, updated_at) " +
                "VALUES(@title, @author, @publisher, @year, @isbn, @category, @edition, NOW(), NOW())";
                cmd = new MySqlCommand(@query, connect);
                cmd.Parameters.AddWithValue("@title", results[0]);
                cmd.Parameters.AddWithValue("@author", results[1]);
                cmd.Parameters.AddWithValue("@publisher", results[2]);
                cmd.Parameters.AddWithValue("@year", Convert.ToInt32(results[3]));
                cmd.Parameters.AddWithValue("@isbn", results[4]);
                cmd.Parameters.AddWithValue("@category", results[5]);
                cmd.Parameters.AddWithValue("@edition", results[6]);
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteBook(int id)
        {
            connect = new MySqlConnection(conn);
            connect.Open();
            string query = "DELETE FROM books WHERE book_id = @id";
            cmd = new MySqlCommand(query, connect);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public void deleteCopies(int id)
        {
            connect = new MySqlConnection(conn);
            connect.Open();
            string query = "DELETE FROM copies WHERE book_id = @id";
            cmd= new MySqlCommand(query, connect);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            connect.Close();
        }
    }
}
