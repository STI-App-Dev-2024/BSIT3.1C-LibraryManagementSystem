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

namespace LibraryManagementSystem.UserControl_Library
{
    public partial class UC_Books : UserControl
    {
        private string conn = "server=localhost;uid=root;password=password;database=librarymanagement";
        MySqlConnection connect;
        public UC_Books()
        {
            InitializeComponent();
            loadGrid();
        }

        private void loadGrid()
        {
            grid_Inventory.AutoGenerateColumns = false;
            grid_Inventory.Rows.Clear();
            try
            {
                connect = new MySqlConnection(conn);
                string query = "SELECT title, author FROM books";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connect);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    grid_Inventory.Rows.Add(
                            row["title"],
                            row["author"]
                        );
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grid_Inventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddBook_Click(object sender, EventArgs e)
        {
            F_AddForm add = new F_AddForm();
            add.ShowDialog();

        }

        private void grid_Inventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (grid_Inventory.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    string column = grid_Inventory.Columns[e.ColumnIndex].HeaderText;
                    int id = Convert.ToInt32(grid_Inventory.Rows[e.RowIndex].Cells[""]);
                }
            }
        }
    }
}
