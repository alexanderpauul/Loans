using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Loan.Data
{
    public class Client
    {
        public int Add(Entities.Models.Client value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Client_Add", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ClientId", value.ClientId));
                cmd.Parameters.Add(new SqlParameter("@FullName", value.FullName));
                cmd.Parameters.Add(new SqlParameter("@DateOfBirth", value.DateOfBirth));
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

        public int Edit(Entities.Models.Client value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Client_Edit", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ClientId", value.ClientId));
                cmd.Parameters.Add(new SqlParameter("@FullName", value.FullName));
                cmd.Parameters.Add(new SqlParameter("@DateOfBirth", value.DateOfBirth));
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
            using (SqlCommand cmd = new SqlCommand("dbo.Client_Delete", Connection.Cnn))
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

        public Entities.Models.Client GetById(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Client_GetById", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Entities.Models.Client record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Entities.Models.Client();
                        record.ClientId = (int)(drResult["ClientId"]);
                        record.FullName = (String)(drResult["FullName"]);
                        record.DateOfBirth = (DateTime)(drResult["DateOfBirth"]);
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

        public Entities.Models.Client GetByGUID(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Client_GetByGUID", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Entities.Models.Client record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Entities.Models.Client();
                        record.ClientId = (int)(drResult["ClientId"]);
                        record.FullName = (String)(drResult["FullName"]);
                        record.DateOfBirth = (DateTime)(drResult["DateOfBirth"]);
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

        public List<Entities.Models.Client> GetAll()
        {
            using (SqlCommand cmd = new SqlCommand("dbo.Client_GetAll", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                IDataReader drResult = null;
                List<Entities.Models.Client> records = new List<Entities.Models.Client>();

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    while (drResult.Read())
                    {
                        Entities.Models.Client record = new Entities.Models.Client();
                        record.ClientId = (int)(drResult["ClientId"]);
                        record.FullName = (String)(drResult["FullName"]);
                        record.DateOfBirth = (DateTime)(drResult["DateOfBirth"]);
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