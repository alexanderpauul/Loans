using System;
using System.Collections.Generic;

namespace Loan.Business
{
    public class LoanBook
    {
        private static Data.LoanBook obj = new Data.LoanBook();

        public static int Add(Entities.Models.LoanBook value)
        {
            return obj.Add(value);
        }

        public static int Edit(Entities.Models.LoanBook value)
        {
            return obj.Edit(value);
        }

        public static int Delete(string value)
        {
            return obj.Delete(value);
        }

        public static Entities.Models.LoanBook GetById(string ID)
        {
            return obj.GetById(ID);
        }

        public static Entities.Models.LoanBook GetByGUID(string ID)
        {
            return obj.GetByGUID(ID);
        }

        public static List<Entities.Models.LoanBook> GetAll()
        {
            return obj.GetAll();
        }

        public static Entities.DTO.Elegible GetCommenFoElegible(DateTime DateOfBirth)
        {

            Entities.DTO.Elegible result = null;

            try
            {
                int age = 0;
                string msgForNotElegible = string.Empty;

                age = DateTime.Today.Year - DateOfBirth.Year;
                if (age < 18)
                {
                    msgForNotElegible = "Lo Sentimos aun no cuenta con la edad para solicitar este producto.";
                }

                if (age > 25)
                {
                    msgForNotElegible = "Favor pasar por una de nuestras sucursales para evaluar su caso.";
                }

                result = new Entities.DTO.Elegible()
                {
                    Age = age,
                    IsElegible = (age > 18 && age < 25) ? true : false,
                    Comment = msgForNotElegible
                };
            }
            catch (Exception e)
            {
                _ = e.Message;
            }

            return result;
        }

        public static decimal CalculationFee(decimal Amount, decimal RateValue, int MonthValue)
        {
            decimal fee = 0;
            try
            {
                fee = ((Amount * RateValue) / MonthValue);
            }
            catch (Exception e)
            {
                _ = e.Message;
            }

            return fee;
        }
    }
}