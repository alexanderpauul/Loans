using System.Collections.Generic;

namespace Loan.Business
{
    public class LoanRate
    {
        private static Data.LoanRate obj = new Data.LoanRate();

        public static int Add(Entities.Models.LoanRate value)
        {
            return obj.Add(value);
        }

        public static int Edit(Entities.Models.LoanRate value)
        {
            return obj.Edit(value);
        }

        public static int Delete(string value)
        {
            return obj.Delete(value);
        }

        public static Entities.Models.LoanRate GetById(string ID)
        {
            return obj.GetById(ID);
        }

        public static Entities.Models.LoanRate GetByGUID(string ID)
        {
            return obj.GetByGUID(ID);
        }

        public static Entities.Models.LoanRate GetByAge(int ID)
        {
            return obj.GetByAge(ID);
        }


        public static List<Entities.Models.LoanRate> GetAll()
        {
            return obj.GetAll();
        }
    }
}