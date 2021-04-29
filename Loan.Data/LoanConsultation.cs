using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Loan.Data
{
    public class LoanConsultation
    {
        public int Add(Entities.Models.LoanConsultation value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.LoanConsultation_Add", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Age", value.Age));
                cmd.Parameters.Add(new SqlParameter("@Amount", value.Amount));
                cmd.Parameters.Add(new SqlParameter("@Months", value.Months));
                cmd.Parameters.Add(new SqlParameter("@AmountFee", value.AmountFee));
                cmd.Parameters.Add(new SqlParameter("@IPClient", value.IPClient));

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

        public int Edit(Entities.Models.LoanConsultation value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.LoanConsultation_Edit", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ConsultationId", value.ConsultationId));
                cmd.Parameters.Add(new SqlParameter("@Registered", value.Registered));
                cmd.Parameters.Add(new SqlParameter("@Age", value.Age));
                cmd.Parameters.Add(new SqlParameter("@Amount", value.Amount));
                cmd.Parameters.Add(new SqlParameter("@Months", value.Months));
                cmd.Parameters.Add(new SqlParameter("@AmountFee", value.AmountFee));
                cmd.Parameters.Add(new SqlParameter("@IPClient", value.IPClient));

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
            using (SqlCommand cmd = new SqlCommand("dbo.LoanConsultation_Delete", Connection.Cnn))
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

        public Entities.Models.LoanConsultation GetById(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.LoanConsultation_GetById", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Entities.Models.LoanConsultation record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Entities.Models.LoanConsultation();
                        record.ConsultationId = (int)(drResult["ConsultationId"]);
                        record.Registered = (DateTime)(drResult["Registered"]);
                        record.Age = (int)(drResult["Age"]);
                        record.Amount = (decimal)(drResult["Amount"]);
                        record.Months = (int)(drResult["Months"]);
                        record.AmountFee = (decimal)(drResult["AmountFee"]);
                        record.IPClient = (String)(drResult["IPClient"]);


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

        public Entities.Models.LoanConsultation GetByGUID(string value)
        {
            using (SqlCommand cmd = new SqlCommand("dbo.LoanConsultation_GetByGUID", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@value", value));
                IDataReader drResult = null;
                Entities.Models.LoanConsultation record = null;

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    if (drResult.Read())
                    {
                        record = new Entities.Models.LoanConsultation();
                        record.ConsultationId = (int)(drResult["ConsultationId"]);
                        record.Registered = (DateTime)(drResult["Registered"]);
                        record.Age = (int)(drResult["Age"]);
                        record.Amount = (decimal)(drResult["Amount"]);
                        record.Months = (int)(drResult["Months"]);
                        record.AmountFee = (decimal)(drResult["AmountFee"]);
                        record.IPClient = (String)(drResult["IPClient"]);


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

        public List<Entities.Models.LoanConsultation> GetAll()
        {
            using (SqlCommand cmd = new SqlCommand("dbo.LoanConsultation_GetAll", Connection.Cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                IDataReader drResult = null;
                List<Entities.Models.LoanConsultation> records = new List<Entities.Models.LoanConsultation>();

                try
                {
                    if (Connection.Cnn.State == ConnectionState.Closed)
                        Connection.Cnn.Open();

                    drResult = cmd.ExecuteReader();
                    while (drResult.Read())
                    {
                        Entities.Models.LoanConsultation record = new Entities.Models.LoanConsultation();
                        record.ConsultationId = (int)(drResult["ConsultationId"]);
                        record.Registered = (DateTime)(drResult["Registered"]);
                        record.Age = (int)(drResult["Age"]);
                        record.Amount = (decimal)(drResult["Amount"]);
                        record.Months = (int)(drResult["Months"]);
                        record.AmountFee = (decimal)(drResult["AmountFee"]);
                        record.IPClient = (String)(drResult["IPClient"]);


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