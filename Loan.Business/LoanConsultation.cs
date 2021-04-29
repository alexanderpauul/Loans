using System.Collections.Generic;
using Loan.Entities.Models;

namespace Loan.Business
{
    public class LoanConsultation
    {
        private static Data.LoanConsultation obj = new Data.LoanConsultation();

        public static int Add(Entities.Models.LoanConsultation value)
        {
            return obj.Add(value);
        }

        public static int Edit(Entities.Models.LoanConsultation value)
        {
            return obj.Edit(value);
        }

        public static int Delete(string value)
        {
            return obj.Delete(value);
        }

        public static Entities.Models.LoanConsultation GetById(string ID)
        {
            return obj.GetById(ID);
        }

        public static Entities.Models.LoanConsultation GetByGUID(string ID)
        {
            return obj.GetByGUID(ID);
        }

        public static List<Entities.Models.LoanConsultation> GetAll()
        {
            return obj.GetAll();
        }
    }
}