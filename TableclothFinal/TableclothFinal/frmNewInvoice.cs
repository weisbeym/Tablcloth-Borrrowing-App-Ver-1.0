using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableclothFinal
{
    public partial class frmNewInvoice : Form
    {
        SqlConnection connection;

        public frmNewInvoice()
        {
            InitializeComponent();
        }

        private void frmNewInvoice_Load(object sender, EventArgs e)
        {
            PopulateBorrowers();
            PopulateProducts();
        }

        private void PopulateBorrowers()
        {
            using (connection = TableclothDB.GetConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT BorrowerId, BorrowerFName + BorrowerLName " +
                "as FullName FROM Borrowers", connection))
            {
                DataTable nameTable = new DataTable();
                adapter.Fill(nameTable);

                cmbBorrower.DisplayMember = "FullName";
                cmbBorrower.ValueMember = "BorrowerId";
                cmbBorrower.DataSource = nameTable;
            }
        }

        private void PopulateProducts()
        {
            using (connection = TableclothDB.GetConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT ProductId, ProductName FROM Product", connection))
            {
                DataTable nameTable = new DataTable();
                adapter.Fill(nameTable);

                cmbProduct.DisplayMember = "ProductName";
                cmbProduct.ValueMember = "ProductId";
                cmbProduct.DataSource = nameTable;
            }
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {

                string insertStatement =
             "INSERT Invoices" +
             "(BorrowerId, ProductId, Quantity, InvoiceDate)" +
             "VALUES (@BorrowerId, @ProductId, @Quantity, @InvoiceDate)";
                SqlCommand insertCommand =
                    new SqlCommand(insertStatement, connection);
                insertCommand.Parameters.AddWithValue(
                    "@BorrowerId", Convert.ToInt32(cmbBorrower.ValueMember));
                insertCommand.Parameters.AddWithValue(
                    "@ProductId", Convert.ToInt32(cmbProduct.ValueMember));
                insertCommand.Parameters.AddWithValue(
                    "@Quantity", Convert.ToInt32(txtQuantity.Text));
                insertCommand.Parameters.AddWithValue(
                    "@InvoiceDate", Convert.ToDateTime(dateTimePicker1.Text));

                try
                {
                    connection.Open();
                    insertCommand.ExecuteNonQuery();
                    string selectStatement =
                        "SELECT IDENT_CURRENT('Invoices') FROM Invoices";
                    SqlCommand selectCommand =
                        new SqlCommand(selectStatement, connection);
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
                this.DialogResult = DialogResult.OK;
                this.Close();


        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
