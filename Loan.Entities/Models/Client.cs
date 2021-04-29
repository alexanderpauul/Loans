using System;

namespace Loan.Entities.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public String FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime Registered { get; set; }
        public Guid Identifier { get; set; }

    }
}
