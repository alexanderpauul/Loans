using System.Collections.Generic;

namespace Loan.Business
{
    public class LoanPayment
    {
        private static Data.LoanPayment obj = new Data.LoanPayment();

        public static int Add(Entities.Models.LoanPayment value)
        {
            return obj.Add(value);
        }

        public static int Edit(Entities.Models.LoanPayment value)
        {
            return obj.Edit(value);
        }

        public static int Delete(string value)
        {
            return obj.Delete(value);
        }

        public static Entities.Models.LoanPayment GetById(string ID)
        {
            return obj.GetById(ID);
        }

        public static Entities.Models.LoanPayment GetByGUID(string ID)
        {
            return obj.GetByGUID(ID);
        }

        public static List<Entities.Models.LoanPayment> GetAll()
        {
            return obj.GetAll();
        }
    }
}