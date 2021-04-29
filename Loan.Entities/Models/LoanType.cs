using System;

namespace Loan.Entities.Models
{
    public class LoanType
    {
        public int LoanTypeId { get; set; }
        public String TypeName { get; set; }
        public int MonthValue { get; set; }
        public DateTime Registered { get; set; }
        public Guid Identifier { get; set; }

    }
}
