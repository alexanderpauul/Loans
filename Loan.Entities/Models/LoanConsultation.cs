using System;

namespace Loan.Entities.Models
{
    public class LoanConsultation
    {
        public int ConsultationId { get; set; }
        public DateTime Registered { get; set; }
        public int Age { get; set; }
        public decimal Amount { get; set; }
        public int Months { get; set; }
        public decimal AmountFee { get; set; }
        public String IPClient { get; set; }

    }
}
