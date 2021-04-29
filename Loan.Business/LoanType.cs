using System.Collections.Generic;

namespace Loan.Business
{
    public class LoanType
    {
        private static Data.LoanType obj = new Data.LoanType();

        public static int Add(Entities.Models.LoanType value)
        {
            return obj.Add(value);
        }

        public static int Edit(Entities.Models.LoanType value)
        {
            return obj.Edit(value);
        }

        public static int Delete(string value)
        {
            return obj.Delete(value);
        }

        public static Entities.Models.LoanType GetById(string ID)
        {
            return obj.GetById(ID);
        }

        public static Entities.Models.LoanType GetByGUID(string ID)
        {
            return obj.GetByGUID(ID);
        }

        public static List<Entities.Models.LoanType> GetAll()
        {
            return obj.GetAll();
        }
    }
}