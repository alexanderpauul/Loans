using Loan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Loan.Utils
{
    public class Rule
    {
        public static Elegible GetCommenFoElegible(DateTime DateOfBirth)
        {

            Elegible result = null;

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

                result = new Elegible()
                {
                    Age = age,
                    IsElegible = (age >= 18 && age <= 25) ? true : false,
                    Comment = msgForNotElegible
                };
            }
            catch (Exception e)
            {
                _ = e.Message;
            }

            return result;
        }
    }
}