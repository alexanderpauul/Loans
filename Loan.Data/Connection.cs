using System.Configuration;
using System.Data.SqlClient;

namespace Loan.Data
{
    class Connection
    {
        private static SqlConnection _cnn = null;


        public static SqlConnection Cnn
        {
            get
            {
                if (_cnn != null)
                {
                    return _cnn;
                }

                _cnn = new SqlConnection(ConfigurationManager.AppSettings["cnn"]);
                return _cnn;
            }
        }

    }
}
