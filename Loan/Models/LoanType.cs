using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Loan.Models
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