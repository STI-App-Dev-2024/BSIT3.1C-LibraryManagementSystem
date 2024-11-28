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

namespace LibraryManagementSystem.UserControl_Library
{
    public partial class UC_Archive_Books : UserControl
    {
        MySqlConnection connection;
        MySqlCommand cmd;

        string conn = "server=localhost;uid=root;password=password;database=librarymanagement";
        public UC_Archive_Books()
        {
            InitializeComponent();
            LoadGrid();
        }

        private void LoadGrid()
        {
            BookArchGrid.AutoGenerateColumns = false;
            BookArchGrid.Rows.Clear();
            try
            {
                connection = new MySqlConnection(conn);
                string query = "SELECT title, author, publisher, year_published, category FROM book_archive";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    BookArchGrid.Rows.Add(
                            row["title"],
                            row["author"],
                            row["publisher"],
                            row["year_published"],
                            row["category"]
                        );
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
