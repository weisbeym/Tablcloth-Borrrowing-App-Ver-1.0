using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TableclothFinal
{
    public static class InvoiceDB
    {
        public static Invoice GetInvoice(int InvoiceId)
        {
            SqlConnection connection = TableclothDB.GetConnection();
            string selectStatement
                = "SELECT InvoiceId, BorrowerId, ProductId, Quantity, InvoiceDate"
                + "FROM Invoices "
                + "WHERE InvoiceId = @InvoiceId";

            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@InvoiceID", InvoiceId);

            try
            {
                connection.Open();
                SqlDataReader custReader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (custReader.Read())
                {
                    Invoice invoice = new Invoice();
                    invoice.InvoiceId = (int)custReader["InvoiceId"];
                    invoice.BorrowerId = (int)custReader["BorrowerId"];
                    invoice.ProductId = (int)custReader["ProductId"];
                    invoice.Quantity = (int)custReader["Quantity"];
                    invoice.InvoiceDate = (DateTime)custReader["InvoiceDate"];
                    return invoice;
                }
                else
                {
                    return null;
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

        public static int AddInvoice(Invoice invoice)
        {
            SqlConnection connection = TableclothDB.GetConnection();
            string insertStatement =
                "INSERT Invoices" +
                "(BorrowerId, ProductId, Quantity, InvoiceDate)" +
                "VALUES (@BorrowerId, @ProductId, @Quantity, @InvoiceDate)";
            SqlCommand insertCommand =
                new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue(
                "@BorrowerId", invoice.BorrowerId);
            insertCommand.Parameters.AddWithValue(
                "@ProductId", invoice.ProductId);
            insertCommand.Parameters.AddWithValue(
                "@Quantity", invoice.Quantity);
            insertCommand.Parameters.AddWithValue(
                "@InvoiceDate", invoice.InvoiceDate);

            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('Invoices') FROM Invoices";
                SqlCommand selectCommand =
                    new SqlCommand(selectStatement, connection);
                int customerID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return customerID;
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

        public static bool UpdateInvoices(Invoice oldInvoice, Invoice newInvoice)
        {
            SqlConnection connection = TableclothDB.GetConnection();
            string updateStatement =
                "UPDATE Invoices SET " +
                "BorrowerId = @NewBorrowerId, " +
                "ProductId = @NewProductId, " +
                "Quantity = @NewQuantity, " +
                "InvoiceDate = @NewInvoiceDate, " +
                "WHERE InvoiceId = @oldInvoiceId " +
                "AND BorrowerId = @OldBorrowerId " +
                "AND ProductId = @OldProductId " +
                "AND Quantity = @OldQuantity " +
                "AND InvoiceDate = @OldInvoiceDate ";
            SqlCommand updateCommand =
                new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue(
                "@NewBorrowerId", newInvoice.BorrowerId);
            updateCommand.Parameters.AddWithValue(
                "@NewProductId", newInvoice.ProductId);
            updateCommand.Parameters.AddWithValue(
                "@NewQuantity", newInvoice.Quantity);
            updateCommand.Parameters.AddWithValue(
                "@NewInvoiceDate", newInvoice.InvoiceDate);
            updateCommand.Parameters.AddWithValue(
                "@OldInvoiceId", oldInvoice.InvoiceId);
            updateCommand.Parameters.AddWithValue(
                "@OldBorrowerId", oldInvoice.BorrowerId);
            updateCommand.Parameters.AddWithValue(
                "@OldProductId", oldInvoice.ProductId);
            updateCommand.Parameters.AddWithValue(
                "@OldQuantity", oldInvoice.Quantity);
            updateCommand.Parameters.AddWithValue(
                "@OldInvoiceDate", oldInvoice.InvoiceDate);

            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
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

        public static bool DeleteInvoice(Invoice invoice)
        {
            SqlConnection connection = TableclothDB.GetConnection();
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
                "@InvoiceId", invoice.InvoiceId);
            deleteCommand.Parameters.AddWithValue(
                "@BorrowerId", invoice.BorrowerId);
            deleteCommand.Parameters.AddWithValue(
                "@ProductId", invoice.ProductId);
            deleteCommand.Parameters.AddWithValue(
                "@Quantity", invoice.Quantity);
            deleteCommand.Parameters.AddWithValue(
                "@InvoiceDate", invoice.InvoiceDate);
            try
            {
                connection.Open();
                int count = deleteCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
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
    }
}
