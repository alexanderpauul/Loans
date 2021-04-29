using System.Collections.Generic;

namespace Loan.Business
{
    public class Client
    {
        private static Data.Client obj = new Data.Client();

        public static int Add(Entities.Models.Client value)
        {
            return obj.Add(value);
        }

        public static int Edit(Entities.Models.Client value)
        {
            return obj.Edit(value);
        }

        public static int Delete(string value)
        {
            return obj.Delete(value);
        }

        public static Entities.Models.Client GetById(string ID)
        {
            return obj.GetById(ID);
        }

        public static Entities.Models.Client GetByGUID(string ID)
        {
            return obj.GetByGUID(ID);
        }

        public static List<Entities.Models.Client> GetAll()
        {
            return obj.GetAll();
        }
    }
}