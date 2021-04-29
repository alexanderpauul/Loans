using Loan.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Web;

namespace Loan.Services
{
    public class ApiServices
    {
        public static async Task<List<LoanConsultation>> GetLoanConsultation()
        {
            using (var client = new HttpClient())
            {

                var json = await client.GetStringAsync(ConfigurationManager.AppSettings["ApiLoanURL"] + "Consultation");
                List<LoanConsultation> response = JsonConvert.DeserializeObject<List<LoanConsultation>>(json);

                return response;
            }
        }

        public static async Task<string> GetCalculationFee(Calculate calculate)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["ApiLoanURL"]);

                HttpResponseMessage response = client.PostAsJsonAsync<Calculate>("CalculationFee", calculate).Result;
                string Amount = await response.Content.ReadAsStringAsync();

                return String.Format("{0:0.##}", Amount);
            }
        }

        public static async Task<List<LoanType>> GetMonthsList()
        {
            using (var client = new HttpClient())
            {

                var json = await client.GetStringAsync(ConfigurationManager.AppSettings["ApiLoanURL"] + "Months");
                List<LoanType> lsLoanType = JsonConvert.DeserializeObject<List<LoanType>>(json);

                return lsLoanType;
            }
        }

        public static async Task<List<LoanRate>> GetRateList()
        {
            using (var client = new HttpClient())
            {

                var json = await client.GetStringAsync(ConfigurationManager.AppSettings["ApiLoanURL"] + "RateType");
                List<LoanRate> lsLoanRate = JsonConvert.DeserializeObject<List<LoanRate>>(json);

                return lsLoanRate;
            }
        }

        public static async Task<LoanRate> GetRateByAge(Elegible value)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["ApiLoanURL"]);

                HttpResponseMessage response = client.PostAsJsonAsync<Elegible>("RateByAge", value).Result;
                LoanRate loanRate = JsonConvert.DeserializeObject<LoanRate>(await response.Content.ReadAsStringAsync());

                return loanRate;
            }
        }
    }
}