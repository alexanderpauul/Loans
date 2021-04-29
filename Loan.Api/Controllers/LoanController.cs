using Loan.Api.Models;
using System;
using System.Web.Http;

namespace Loan.Api.Controllers
{
    [RoutePrefix("api/loan")]
    public class LoanController : ApiController
    {
        [HttpPost]
        [Route("CalculationFee")]
        public IHttpActionResult getCalculationFee(Calculate value)
        {
            try
            {
                // Checking ege, if the client is elegible, comment will be empty,
                // otherwise this method will return a message according to age. 
                Entities.DTO.Elegible Eligibility = Business.LoanBook.GetCommenFoElegible(value.DateOfBirth);

                // If client is elegible, calculate fee and save consultation.
                decimal calclatedFee = Business.LoanBook.CalculationFee(value.Amount, value.RateValue, value.MonthValue);

                // Save consultation log
                var consultation = new Entities.Models.LoanConsultation()
                {
                    Age = Eligibility.Age,
                    Amount = value.Amount,
                    Months = value.MonthValue,
                    AmountFee = calclatedFee,
                    IPClient = value.IPClient
                };

                int result = Business.LoanConsultation.Add(consultation);
                if (result != 0)
                {
                    return Eligibility.IsElegible == false ?
                                                     BadRequest(Eligibility.Comment) :
                                                     (IHttpActionResult)Ok(calclatedFee);
                }
                else
                {
                    return BadRequest("No se pudo obtener la cuota.");
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                return BadRequest("Ha ocurrido un error.");
            }
        }

        [HttpGet]
        [Route("Months")]
        public IHttpActionResult getMonths()
        {
            try
            {
                var months = Business.LoanType.GetAll();
                if (months != null)
                    return Ok(months);
                else
                    return Ok();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                return BadRequest("No se pudo obtener las cuotas.");
            }
        }

        [HttpGet]
        [Route("RateType")]
        public IHttpActionResult getRateType()
        {
            try
            {
                var months = Business.LoanRate.GetAll();
                if (months != null)
                    return Ok(months);
                else
                    return Ok();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                return BadRequest("No se pudo obtener las tasas por edad.");
            }
        }

        [HttpGet]
        [Route("Consultation")]
        public IHttpActionResult getConsultation()
        {
            try
            {
                var consultation = Business.LoanConsultation.GetAll();
                if (consultation != null)
                    return Ok(consultation);
                else
                    return Ok();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                return BadRequest("No se pudo obtener la lista de consulta.");
            }
        }

        [HttpPost]
        [Route("RateByAge")]
        public IHttpActionResult getRateByAge(Elegible value)
        {
            try
            {
                var result = Business.LoanRate.GetByAge(value.Age);
                if (result != null)
                    return Ok(result);
                else
                    return Ok();
            }
            catch (Exception e)
            {
                _ = e.Message;
                return BadRequest("No se pudo obtener la la tasa para la edad.");
            }
        }
    }
}
