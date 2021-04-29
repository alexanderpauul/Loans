using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Loan.Api.Models
{
    public class Elegible
    {
        public int Age { get; set; }
        public bool IsElegible { get; set; }
        public string Comment { get; set; }
    }
}