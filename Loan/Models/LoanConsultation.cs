using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Loan.Models
{
    public class LoanConsultation
    {
        [DisplayName("Id consulta")]
        public int ConsultationId { get; set; }

        [DisplayName("Fecha de consulta")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Registered { get; set; }

        [DisplayName("Edad")]
        public int Age { get; set; }

        [DisplayName("Monto")]
        public decimal Amount { get; set; }

        [DisplayName("Meses")]
        public int Months { get; set; }

        [DisplayName("Valor Cuota")]
        public decimal AmountFee { get; set; }

        [DisplayName("IP de Cliente")]
        public String IPClient { get; set; }
    }
}