using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TableclothFinal
{
    public static class BorrowerDB
    {
        public static Borrowers GetBorrower(int BorrowerId)
        {
            SqlConnection connection = TableclothDB.GetConnection();
            string selectStatement
                = "SELECT BorrowerId, BorrowerFName, BorrowerLName, BorrowerPhoneNumber, BorrowerEmail"
                + "FROM Borrowers "
                + "WHERE BorrowerId = @BorrowerId";

            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@BorrowerId", BorrowerId);

            try
            {
                connection.Open();
                SqlDataReader custReader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (custReader.Read())
                {
                    Borrowers borrower = new Borrowers();
                    borrower.BorrowerId = (int)custReader["BorrowerId"];
                    borrower.BorrowerFName = custReader["BorrowerFName"].ToString();
                    borrower.BorrowerLName = custReader["BorrowerLName"].ToString();
                    borrower.BorrowerPhoneNumber = custReader["BorrowerPhoneNumber"].ToString();
                    borrower.BorrowerEmail = custReader["BorrowerEmail"].ToString();
                    return borrower;
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

        public static int AddBorrower(Borrowers borrower)
        {
            SqlConnection connection = TableclothDB.GetConnection();
            string insertStatement =
                "INSERT Borrowers" +
                "(BorrowerFName, BorrowerLName, BorrowerPhoneNumber, BorrowerEmail)" +
                "VALUES (@BorrowerFName, @BorrowerLName, @BorrowerPhoneNumber, @BorrowerEmail)";
            SqlCommand insertCommand =
                new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue(
                "@BorrowerFName", borrower.BorrowerFName);
            insertCommand.Parameters.AddWithValue(
                "@BorrowerLName", borrower.BorrowerLName);
            insertCommand.Parameters.AddWithValue(
                "@BorrowerPhoneNumber", borrower.BorrowerPhoneNumber);
            insertCommand.Parameters.AddWithValue(
                "@BorrowerEmail", borrower.BorrowerEmail);

            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('Borrowers') FROM Borrowers";
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

        public static bool UpdateBorrower(Borrowers oldBorrower, Borrowers newBorrower)
        {
            SqlConnection connection = TableclothDB.GetConnection();
            string updateStatement =
                "UPDATE Borrowers SET " +
                "BorrowerFName = @NewBorrowerFName, " +
                "BorrowerLName = @NewBorrowerLName, " +
                "BorrowerPhoneNumber = @NewBorrowerPhoneNumber, " +
                "BorrowerEmail = @NewBorrowerEmail, " +
                "WHERE BorrowerId = @oldBorrowerId " +
                "AND BorrowerFName = @OldBorrowerFName " +
                "AND BorrowerLName = @OldBorrowerLName " +
                "AND BorrowerPhoneNumber = @OldBorrowerPhoneNumber " +
                "AND BorrowerEmail = @OldBorrowerEmail ";
            SqlCommand updateCommand =
                new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue(
                "@NewBorrowerFName", newBorrower.BorrowerFName);
            updateCommand.Parameters.AddWithValue(
                "@NewBorrowerLName", newBorrower.BorrowerLName);
            updateCommand.Parameters.AddWithValue(
                "@NewBorrowerPhoneNumber", newBorrower.BorrowerPhoneNumber);
            updateCommand.Parameters.AddWithValue(
                "@NewBorrowerEmail", newBorrower.BorrowerEmail);
            updateCommand.Parameters.AddWithValue(
                "@OldBorrowerId", oldBorrower.BorrowerId);
            updateCommand.Parameters.AddWithValue(
                "@OldBorrowerFName", oldBorrower.BorrowerFName);
            updateCommand.Parameters.AddWithValue(
                "@OldBorrowerLName", oldBorrower.BorrowerLName);
            updateCommand.Parameters.AddWithValue(
                "@OldBorrowerPhoneNumber", oldBorrower.BorrowerPhoneNumber);
            updateCommand.Parameters.AddWithValue(
                "@OldBorrowerEmail", oldBorrower.BorrowerEmail);
     
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

        public static bool DeleteBorrower(Borrowers borrower)
        {
            SqlConnection connection = TableclothDB.GetConnection();
            string deleteStatement =
                "DELETE FROM Borrowers " +
                "WHERE BorrowerId = @BorrowerId " +
                "AND BorrowerFName = @BorrowerFName " +
                "AND BorrowerLName = @BorrowerLName " +
                "AND BorrowerPhoneNumber = @BorrowerPhoneNumber " +
                "AND BorrowerEmail = @BorrowerEmail ";
            SqlCommand deleteCommand =
                new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue(
                "@BorrowerId", borrower.BorrowerId);
            deleteCommand.Parameters.AddWithValue(
                "@BorrowerFName", borrower.BorrowerFName);
            deleteCommand.Parameters.AddWithValue(
                "@BorrowerLName", borrower.BorrowerLName);
            deleteCommand.Parameters.AddWithValue(
                "@BorrowerPhoneNumber", borrower.BorrowerPhoneNumber);
            deleteCommand.Parameters.AddWithValue(
                "@BorrowerEmail", borrower.BorrowerEmail);
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
