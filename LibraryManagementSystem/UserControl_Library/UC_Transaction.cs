using LibraryManagementSystem.General_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace LibraryManagementSystem.UserControl_Library
{
    public partial class UC_Transaction : UserControl
    {
        private General_Class.Transaction transact = new General_Class.Transaction();
        List<int> selectedID = new List<int>();
        public UC_Transaction()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Fullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Checkout_Click(object sender, EventArgs e)
        {

        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void AddCopiesToGrid(string barcode)
        {
            cartGrid.Rows.Clear();
            List<BookModel> copies = transact.GetCopies(barcode);
            foreach (var cop in copies)
            {
                cartGrid.Rows.Add(
                    cop.CopyID,
                    cop.AccessionNumber,
                    cop.Title,
                    cop.Author,
                    cop.Status
                    );
            }
        }

        private void btn_Checkout_Click_1(object sender, EventArgs e)
        {
            string accessNum = "";
            try
            {
                if (cartGrid.Rows.Count == 0 || string.IsNullOrWhiteSpace(txtStuNo.Text))
                {
                    MessageBox.Show("Please add books and provide a valid Student ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }   

                selectedID.Clear();
                foreach (DataGridViewRow row in cartGrid.Rows)
                {
                    if (row.Cells["Status"].Value.ToString() == "Available")
                    {
                        selectedID.Add(Convert.ToInt32(row.Cells["copyid"].Value));
                        accessNum = row.Cells["accessNum"].Value.ToString();
                    }
                }
                string[] info =
                {
                    txtStuNo.Text,
                    txtFirstName.Text,
                    txtLastName.Text,
                    txtEmail.Text
                };
           
                transact.ConfirmTransact(Convert.ToInt32(txtStuNo.Text.ToString()), selectedID, accessNum, info);
                MessageBox.Show("Transaction confirmed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cartGrid.Rows.Clear();
                txtStuNo.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBarcode_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtBarcode.Text))
            {
                string barcode = txtBarcode.Text.Trim();
                AddCopiesToGrid(barcode);
                txtBarcode.Clear();
            }
        }

        private void cartGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
