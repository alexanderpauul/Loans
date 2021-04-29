using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Loan.Data
{
    public class LoanPayment
    {
        public int Add(Entities.Models.LoanPayment value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.LoanPayment_Add", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@LoanPaymentId", value.LoanPaymentId));
                cmd.Parameters.Add(new SqlParameter("@LoanId", value.LoanId));
                cmd.Parameters.Add(new SqlParameter("@Payment", value.Payment));
                cmd.Parameters.Add(new SqlParameter("@Balance", value.Balance));
                cmd.Parameters.Add(new SqlParameter("@PaymentReceived", value.PaymentReceived));
                cmd.Parameters.Add(new SqlParameter("@Comment", value.Comment));
                cmd.Parameters.Add(new SqlParameter("@Identifier", value.Identifier));

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    return (int)(cmd.ExecuteScalar());
                }
                catch (SqlException ex)
                {
                    return 0;
                    throw new Exception("Error ", ex);
                }
                finally
                {
                    if (Connection.Cnn.State == ConnectionState.Open)
                        Connection.Cnn.Close();
                }
            }
        }

        public int Edit(Entities.Models.LoanPayment value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.LoanPayment_Edit", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@LoanPaymentId", value.LoanPaymentId));
                cmd.Parameters.Add(new SqlParameter("@LoanId", value.LoanId));
                cmd.Parameters.Add(new SqlParameter("@Payment", value.Payment));
                cmd.Parameters.Add(new SqlParameter("@Balance", value.Balance));
                cmd.Parameters.Add(new SqlParameter("@PaymentReceived", value.PaymentReceived));
                cmd.Parameters.Add(new SqlParameter("@Comment", value.Comment));
                cmd.Parameters.Add(new SqlParameter("@Identifier", value.Identifier));

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    return (int)(cmd.ExecuteScalar());
                }
                catch (SqlException ex)
                {
                    return 0;
                    throw new Exception("Error ", ex);
                }
                finally
                {
                    if (Connection.Cnn.State == ConnectionState.Open)
                        Connection.Cnn.Close();
                }
            }
        }

        public int Delete(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.LoanPayment_Delete", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    return (int)(cmd.ExecuteScalar());
                }
                catch (SqlException ex)
                {
                    return 0;
                    throw new Exception("Error ", ex);
                }
                finally
                {
                    if (Connection.Cnn.State == ConnectionState.Open)
                        Connection.Cnn.Close();
                }
            }
        }

        public Entities.Models.LoanPayment GetById(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.LoanPayment_GetById", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Entities.Models.LoanPayment record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Entities.Models.LoanPayment();
                        record.LoanPaymentId = (int)(drResult["LoanPaymentId"]);
                        record.LoanId = (int)(drResult["LoanId"]);
                        record.Payment = (decimal)(drResult["Payment"]);
                        record.Balance = (decimal)(drResult["Balance"]);
                        record.PaymentReceived = (DateTime)(drResult["PaymentReceived"]);
                        record.Comment = (String)(drResult["Comment"]);
                        record.Identifier = (Guid)(drResult["Identifier"]);


                    }

                    return record;
                }
                catch (SqlException ex)
                {
                    return record;
                    throw new Exception("Error ", ex);
                }
                finally
                {
                    if (Connection.Cnn.State == ConnectionState.Open)
                        Connection.Cnn.Close();
                }
            }
        }

        public Entities.Models.LoanPayment GetByGUID(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.LoanPayment_GetByGUID", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Entities.Models.LoanPayment record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Entities.Models.LoanPayment();
                        record.LoanPaymentId = (int)(drResult["LoanPaymentId"]);
                        record.LoanId = (int)(drResult["LoanId"]);
                        record.Payment = (decimal)(drResult["Payment"]);
                        record.Balance = (decimal)(drResult["Balance"]);
                        record.PaymentReceived = (DateTime)(drResult["PaymentReceived"]);
                        record.Comment = (String)(drResult["Comment"]);
                        record.Identifier = (Guid)(drResult["Identifier"]);


                    }

                    return record;
                }
                catch (SqlException ex)
                {
                    return record;
                    throw new Exception("Error ", ex);
                }
                finally
                {
                    if (Connection.Cnn.State == ConnectionState.Open)
                        Connection.Cnn.Close();
                }
            }
        }

        public List<Entities.Models.LoanPayment> GetAll()
        {
            using (SqlCommand cmd = new SqlCommand("dbo.LoanPayment_GetAll", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                IDataReader drResult = null;
                List<Entities.Models.LoanPayment> records = new List<Entities.Models.LoanPayment>();

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    while (drResult.Read())
                    {
                        Entities.Models.LoanPayment record = new Entities.Models.LoanPayment();
                        record.LoanPaymentId = (int)(drResult["LoanPaymentId"]);
                        record.LoanId = (int)(drResult["LoanId"]);
                        record.Payment = (decimal)(drResult["Payment"]);
                        record.Balance = (decimal)(drResult["Balance"]);
                        record.PaymentReceived = (DateTime)(drResult["PaymentReceived"]);
                        record.Comment = (String)(drResult["Comment"]);
                        record.Identifier = (Guid)(drResult["Identifier"]);


                        records.Add(record);
                    }

                    return records;
                }
                catch (SqlException ex)
                {
                    return records;
                    throw new Exception("Error ", ex);
                }
                finally
                {
                    if (Connection.Cnn.State == ConnectionState.Open)
                        Connection.Cnn.Close();
                }
            }
        }
    }
}