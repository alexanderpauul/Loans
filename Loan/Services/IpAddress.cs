using System;
using System.Web;

namespace Loan.Services
{
    public class IpAddress
    {
        public static string GetIPClient
        {
            get
            {
                string userIP = HttpContext.Current.Request.UserHostAddress;
                string userIP2 = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];

                string ip = userIP == "0" ? userIP : userIP2;

                return ip;
            }
        }
    }
}