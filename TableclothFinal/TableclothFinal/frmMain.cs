using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TableclothFinal
{
    public partial class frmMain : Form
    {
        SqlConnection connection;

        public frmMain()
        {
            InitializeComponent();
        }

        private void borrowersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            PopulateNames();
        }

        private void PopulateNames()
        {
            using (connection = TableclothDB.GetConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT BorrowerId, BorrowerFName + BorrowerLName " +
                "as FullName FROM Borrowers", connection))
            {
                DataTable nameTable = new DataTable();
                adapter.Fill(nameTable);

                cmbChooseBrrwr.DisplayMember = "FullName";
                cmbChooseBrrwr.ValueMember = "BorrowerId";
                cmbChooseBrrwr.DataSource = nameTable;
            }
        }

        private void PopulateInvoice()
        {
            /* query to get the invoices matching to the selected borrower from the combo box, 
             * using an alias so I can refference that borrowerId value in the PopulateNames method*/
            string query = "SELECT *" +
                "FROM Invoices a INNER JOIN Borrowers b ON a.BorrowerId = b.BorrowerId " +
                "WHERE b.BorrowerId = @BorrowerId";

            using (connection = TableclothDB.GetConnection())
            using(SqlCommand command = new SqlCommand(query, connection))
            /* sqlcommand is the same as a data adapter except it allows parameters, 
             and thats why we pass the query and connection there first unlike by populateName*/ 
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@BorrowerId", cmbChooseBrrwr.SelectedValue);
                DataTable invoiceTable = new DataTable();
                adapter.Fill(invoiceTable);
                
                lstInvoiceId.DisplayMember = "InvoiceId";
                lstInvoiceId.ValueMember = "InvoiceId";
                lstInvoiceId.DataSource = invoiceTable;

                lstBorrowerId.DisplayMember = "BorrowerId";
                lstBorrowerId.ValueMember = "BorrowerId";
                lstBorrowerId.DataSource = invoiceTable;

                lstProductId.DisplayMember = "ProductId";
                lstProductId.ValueMember = "ProductId";
                lstProductId.DataSource = invoiceTable;

                lstQuantity.DisplayMember = "Quantity";
                lstQuantity.ValueMember = "Quantity";
                lstQuantity.DataSource = invoiceTable;

                lstDate.DisplayMember = "InvoiceDate";
                lstDate.ValueMember = "InvoiceDate";
                lstDate.DataSource = invoiceTable;
            }
        }

        private void cmbChooseBrrwr_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateInvoice();
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            frmNewInvoice newInvoiceForm = new frmNewInvoice();
            DialogResult SelectedButton = newInvoiceForm.ShowDialog();

            if(SelectedButton == DialogResult.OK)
            {
                PopulateInvoice();
            }
        }

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            bool works;
            string message = "Are you sure you want to delete invoice" + lstInvoiceId.SelectedValue + "?";
            string command1 = "SELECT *" +
                "FROM Invoices a INNER JOIN Borrowers b ON a.BorrowerId = b.BorrowerId " +
                "WHERE b.BorrowerId = @BorrowerId";

            DialogResult button =
                    MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);
            if (button == DialogResult.Yes)
            {
                using (connection = TableclothDB.GetConnection())
                using (SqlCommand command = new SqlCommand(command1, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    command.Parameters.AddWithValue("@BorrowerId", lstInvoiceId.SelectedValue);
                    DataTable invoiceTable = new DataTable();
                    adapter.Fill(invoiceTable);

                    string deleteStatement =
                        "DELETE FROM Invoices " +
                        "WHERE InvoiceId = @InvoiceId " +
                        "AND BorrowerId = @BorrowerId " +
                        "AND ProductId = @ProductId " +
                        "AND Quantity = @Quantity " +
                        "AND InvoiceDate = @InvoiceDate ";
                    SqlCommand deleteCommand =
                        new SqlCommand(deleteStatement, connection);
                    deleteCommand.Parameters.AddWithValue(
                        "@InvoiceId", Convert.ToInt32(lstInvoiceId.SelectedValue));
                    deleteCommand.Parameters.AddWithValue(
                        "@BorrowerId", Convert.ToInt32(lstBorrowerId.SelectedValue));
                    deleteCommand.Parameters.AddWithValue(
                        "@ProductId", Convert.ToInt32(lstProductId.SelectedValue));
                    deleteCommand.Parameters.AddWithValue(
                        "@Quantity", Convert.ToInt32(lstQuantity.SelectedValue));
                    deleteCommand.Parameters.AddWithValue(
                        "@InvoiceDate", Convert.ToDateTime(lstDate.SelectedValue));
                    try
                    {
                        connection.Open();
                        int count = deleteCommand.ExecuteNonQuery();
                        if (count > 0)
                            works = true;
                        else
                            works = false;
                        if(works == false)
                        {
                            MessageBox.Show("Problem with SQL Command!");
                        }
                    }
                    catch (SqlException ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
                
                PopulateInvoice();
            }
        }

        private void lstInvoiceId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
