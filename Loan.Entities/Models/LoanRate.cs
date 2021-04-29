using System;

namespace Loan.Entities.Models
{
    public class LoanRate
    {
        public int RateId { get; set; }
        public int RateAge { get; set; }
        public decimal RateValue { get; set; }
        public DateTime Registered { get; set; }
        public Guid Identifier { get; set; }

    }
}
