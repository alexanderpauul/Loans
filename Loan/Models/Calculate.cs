using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Loan.Models
{
    public class Calculate
    {
        [Required]
        [DisplayName("Monto Prestamo")]
        public decimal Amount { get; set; }

        [Required]
        [DisplayName("Tasa")]
        public decimal RateValue { get; set; }

        [Required]
        [DisplayName("Meses del Prestamo")]
        public int MonthValue { get; set; }

        [Required]
        [DisplayName("Fecha Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public string IPClient { get; set; }
    }
}