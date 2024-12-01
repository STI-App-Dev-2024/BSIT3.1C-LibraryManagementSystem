using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.General_Class
{
    class Transaction
    {
        MySqlConnection connection;
        MySqlCommand cmd;

        string conn = "server=localhost;uid=root;password=password;database=librarymanagement";

        public List<BookModel> GetCopies(string barcode)
        {
            List<BookModel> bookcopy = new List<BookModel>();
            try
            {
                connection = new MySqlConnection(conn);
                connection.Open();
                string query = "SELECT c.copy_id, c.accession_number, b.title, b.author, c.status " +
                    "FROM copies c " +
                    "JOIN books b ON c.book_id = b.book_id " +
                    "WHERE b.barcode = @barcode AND c.status = 'Available' " +
                    "LIMIT 1";
                cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@barcode", barcode);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bookcopy.Add(new BookModel()
                    {
                        CopyID = Convert.ToInt32(reader["copy_id"]),
                        AccessionNumber = reader["accession_number"].ToString(),
                        Title = reader["title"].ToString(),
                        Author = reader["author"].ToString(),
                        Status = reader["status"].ToString()

                    });
                }
                reader.Close();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            return bookcopy;
        }

        public void ConfirmTransact(int studentID, List<int> copyID, string accessNumber, string[] info)
        {
            connection = new MySqlConnection(conn);
            connection.Open();
            int id;
            //int stuNo = Convert.ToInt32(studentID);
            DateTime due = DateTime.Now.AddDays(14);

            MySqlTransaction transaction = connection.BeginTransaction();
            try
            {
                if (IsRegistered(Convert.ToInt32(studentID)) == false)
                {
                    id = InsertStudent(info);
                }
                foreach (int i in copyID)
                {
                    connection.Open();
                    string query = "INSERT INTO transactions(copy_id, student_id, borrow_date, " +
                        "due_date, status, created_by, updated_by) VALUES(" +
                        "@copy, @stu, NOW(), @due, @status, NOW(), NOW())";
                    MySqlCommand transact = new MySqlCommand(query, connection);
                    transact.Transaction = transaction;
                    transact.Parameters.AddWithValue("@copy", i);
                    transact.Parameters.AddWithValue("@stu", studentID);
                    transact.Parameters.AddWithValue("@due", due);
                    transact.Parameters.AddWithValue("@status", "On-Going");
                    transact.ExecuteNonQuery();
                    connection.Close();

                    connection = new MySqlConnection(conn);
                    connection.Open();
                    string update = "UPDATE copies SET status = 'Borrowed' WHERE copy_id = @id";
                    MySqlCommand command = new MySqlCommand(update, connection);
                    command.Transaction = transaction;
                    command.Parameters.AddWithValue("@id", i);
                    command.ExecuteNonQuery();

                }
                transaction.Commit();

                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                transaction.Rollback();

            }
        } 

        public int InsertStudent(string[] studentInfo)
        {
            connection = new MySqlConnection(conn);
            

            string query = "INSERT INTO students VALUES (" +
                "@id, @first, @last, @email, 10, @status, NOW(), NOW())";
            try
            {
                connection.Open();
                cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(studentInfo[0]));
                cmd.Parameters.AddWithValue("@first", studentInfo[1]);
                cmd.Parameters.AddWithValue("@last", studentInfo[2]);
                cmd.Parameters.AddWithValue("@email", studentInfo[3]);
                cmd.Parameters.AddWithValue("@status", "Active");
                cmd.ExecuteNonQuery();

                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return Convert.ToInt32(studentInfo[0]);
        }

        public bool IsRegistered(int stuNo)
        {
            bool _isRegistered = false;

            try
            {
                connection = new MySqlConnection(conn);
                connection.Open();

                string query = "SELECT COUNT(*) FROM students WHERE student_id = @stuNo";
                cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@stuNo", stuNo);

                int result = Convert.ToInt32(cmd.ExecuteScalar()) ;
                connection.Close();
                if (result == 1)
                {
                    _isRegistered = true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return _isRegistered;
        }
    }

}
