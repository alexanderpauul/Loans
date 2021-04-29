using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Loan.Data
{
    public class LoanType
    {
        public int Add(Entities.Models.LoanType value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.LoanType_Add", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@LoanTypeId", value.LoanTypeId));
                cmd.Parameters.Add(new SqlParameter("@TypeName", value.TypeName));
                cmd.Parameters.Add(new SqlParameter("@MonthValue", value.MonthValue));
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

        public int Edit(Entities.Models.LoanType value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.LoanType_Edit", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@LoanTypeId", value.LoanTypeId));
                cmd.Parameters.Add(new SqlParameter("@TypeName", value.TypeName));
                cmd.Parameters.Add(new SqlParameter("@MonthValue", value.MonthValue));
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
            using (SqlCommand cmd = new SqlCommand("dbo.LoanType_Delete", Connection.Cnn))
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

        public Entities.Models.LoanType GetById(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.LoanType_GetById", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Entities.Models.LoanType record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Entities.Models.LoanType();
                        record.LoanTypeId = (int)(drResult["LoanTypeId"]);
                        record.TypeName = (String)(drResult["TypeName"]);
                        record.MonthValue = (int)(drResult["MonthValue"]);
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

        public Entities.Models.LoanType GetByGUID(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.LoanType_GetByGUID", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Entities.Models.LoanType record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Entities.Models.LoanType();
                        record.LoanTypeId = (int)(drResult["LoanTypeId"]);
                        record.TypeName = (String)(drResult["TypeName"]);
                        record.MonthValue = (int)(drResult["MonthValue"]);
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

        public List<Entities.Models.LoanType> GetAll()
        {
            using (SqlCommand cmd = new SqlCommand("dbo.LoanType_GetAll", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                IDataReader drResult = null;
                List<Entities.Models.LoanType> records = new List<Entities.Models.LoanType>();

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    while (drResult.Read())
                    {
                        Entities.Models.LoanType record = new Entities.Models.LoanType();
                        record.LoanTypeId = (int)(drResult["LoanTypeId"]);
                        record.TypeName = (String)(drResult["TypeName"]);
                        record.MonthValue = (int)(drResult["MonthValue"]);
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