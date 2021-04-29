using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Loan.Data
{
    public class LoanRate
    {
        public int Add(Entities.Models.LoanRate value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.LoanRate_Add", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@RateId", value.RateId));
                cmd.Parameters.Add(new SqlParameter("@RateAge", value.RateAge));
                cmd.Parameters.Add(new SqlParameter("@RateValue", value.RateValue));
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

        public int Edit(Entities.Models.LoanRate value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.LoanRate_Edit", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@RateId", value.RateId));
                cmd.Parameters.Add(new SqlParameter("@RateAge", value.RateAge));
                cmd.Parameters.Add(new SqlParameter("@RateValue", value.RateValue));
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
            using (SqlCommand cmd = new SqlCommand("dbo.LoanRate_Delete", Connection.Cnn))
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

        public Entities.Models.LoanRate GetById(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.LoanRate_GetById", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Entities.Models.LoanRate record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Entities.Models.LoanRate();
                        record.RateId = (int)(drResult["RateId"]);
                        record.RateAge = (int)(drResult["RateAge"]);
                        record.RateValue = (decimal)(drResult["RateValue"]);
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

        public Entities.Models.LoanRate GetByGUID(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.LoanRate_GetByGUID", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Entities.Models.LoanRate record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Entities.Models.LoanRate();
                        record.RateId = (int)(drResult["RateId"]);
                        record.RateAge = (int)(drResult["RateAge"]);
                        record.RateValue = (decimal)(drResult["RateValue"]);
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

        public Entities.Models.LoanRate GetByAge(int value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.LoanRate_GetByAge", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Entities.Models.LoanRate record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Entities.Models.LoanRate();
                        record.RateId = (int)(drResult["RateId"]);
                        record.RateAge = (int)(drResult["RateAge"]);
                        record.RateValue = (decimal)(drResult["RateValue"]);
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

        public List<Entities.Models.LoanRate> GetAll()
        {
            using (SqlCommand cmd = new SqlCommand("dbo.LoanRate_GetAll", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                IDataReader drResult = null;
                List<Entities.Models.LoanRate> records = new List<Entities.Models.LoanRate>();

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    while (drResult.Read())
                    {
                        Entities.Models.LoanRate record = new Entities.Models.LoanRate();
                        record.RateId = (int)(drResult["RateId"]);
                        record.RateAge = (int)(drResult["RateAge"]);
                        record.RateValue = (decimal)(drResult["RateValue"]);
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