using System;

namespace Loan.Entities.Models
{
    public class LoanPayment
    {
        public int LoanPaymentId { get; set; }
        public int LoanId { get; set; }
        public decimal Payment { get; set; }
        public decimal Balance { get; set; }
        public DateTime PaymentReceived { get; set; }
        public String Comment { get; set; }
        public Guid Identifier { get; set; }

    }
}
