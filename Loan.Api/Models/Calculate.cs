using System;

namespace Loan.Api.Models
{
    public class Calculate
    {
        public decimal Amount { get; set; }
        public decimal RateValue { get; set; }
        public int MonthValue { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IPClient { get; set; }
    }
}