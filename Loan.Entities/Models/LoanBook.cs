using System;

namespace Loan.Entities.Models
{
    public class LoanBook
    {
        public int LoanId { get; set; }
        public decimal Amount { get; set; }
        public int RateId { get; set; }
        public int LoanTypeId { get; set; }
        public int ClientId { get; set; }
        public DateTime Registered { get; set; }
        public Guid Identifier { get; set; }

    }
}
