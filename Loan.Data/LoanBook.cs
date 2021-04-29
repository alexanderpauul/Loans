using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Loan.Data
{
    public class LoanBook
    {
        public int Add(Entities.Models.LoanBook value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.LoanBook_Add", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@LoanId", value.LoanId));
                cmd.Parameters.Add(new SqlParameter("@Amount", value.Amount));
                cmd.Parameters.Add(new SqlParameter("@RateId", value.RateId));
                cmd.Parameters.Add(new SqlParameter("@LoanTypeId", value.LoanTypeId));
                cmd.Parameters.Add(new SqlParameter("@ClientId", value.ClientId));
                cmd.Parameters.Add(new SqlParameter("@Registered", value.Registered));
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

        public int Edit(Entities.Models.LoanBook value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.LoanBook_Edit", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@LoanId", value.LoanId));
                cmd.Parameters.Add(new SqlParameter("@Amount", value.Amount));
                cmd.Parameters.Add(new SqlParameter("@RateId", value.RateId));
                cmd.Parameters.Add(new SqlParameter("@LoanTypeId", value.LoanTypeId));
                cmd.Parameters.Add(new SqlParameter("@ClientId", value.ClientId));
                cmd.Parameters.Add(new SqlParameter("@Registered", value.Registered));
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
            using (SqlCommand cmd = new SqlCommand("dbo.LoanBook_Delete", Connection.Cnn))
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

        public Entities.Models.LoanBook GetById(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.LoanBook_GetById", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Entities.Models.LoanBook record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Entities.Models.LoanBook();
                        record.LoanId = (int)(drResult["LoanId"]);
                        record.Amount = (decimal)(drResult["Amount"]);
                        record.RateId = (int)(drResult["RateId"]);
                        record.LoanTypeId = (int)(drResult["LoanTypeId"]);
                        record.ClientId = (int)(drResult["ClientId"]);
                        record.Registered = (DateTime)(drResult["Registered"]);
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

        public Entities.Models.LoanBook GetByGUID(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.LoanBook_GetByGUID", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Entities.Models.LoanBook record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Entities.Models.LoanBook();
                        record.LoanId = (int)(drResult["LoanId"]);
                        record.Amount = (decimal)(drResult["Amount"]);
                        record.RateId = (int)(drResult["RateId"]);
                        record.LoanTypeId = (int)(drResult["LoanTypeId"]);
                        record.ClientId = (int)(drResult["ClientId"]);
                        record.Registered = (DateTime)(drResult["Registered"]);
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

        public List<Entities.Models.LoanBook> GetAll()
        {
            using (SqlCommand cmd = new SqlCommand("dbo.LoanBook_GetAll", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                IDataReader drResult = null;
                List<Entities.Models.LoanBook> records = new List<Entities.Models.LoanBook>();

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    while (drResult.Read())
                    {
                        Entities.Models.LoanBook record = new Entities.Models.LoanBook();
                        record.LoanId = (int)(drResult["LoanId"]);
                        record.Amount = (decimal)(drResult["Amount"]);
                        record.RateId = (int)(drResult["RateId"]);
                        record.LoanTypeId = (int)(drResult["LoanTypeId"]);
                        record.ClientId = (int)(drResult["ClientId"]);
                        record.Registered = (DateTime)(drResult["Registered"]);
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