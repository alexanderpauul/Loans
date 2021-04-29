using Loan.Models;
using Loan.Services;
using Loan.Utils;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Loan.Controllers
{
    public class HomeController : Controller
    {

        public async Task<ActionResult> Consultation()
        {
            var consultations = await ApiServices.GetLoanConsultation();
            return View(consultations);
        }


        public async Task<ActionResult> Calculator()
        {
            ViewBag.Months = new SelectList(await Services.ApiServices.GetMonthsList(), "MonthValue", "TypeName");

            return View();
        }


        [HttpPost]
        public async Task<ActionResult> Calculator(Calculate calculate)
        {
            if (ModelState.IsValid)
            {
                Elegible Eligibility = Rule.GetCommenFoElegible(calculate.DateOfBirth);
                ViewBag.Months = new SelectList(await Services.ApiServices.GetMonthsList(), "MonthValue", "TypeName");

                if (Eligibility.IsElegible == false)
                {
                    ModelState.AddModelError("", Eligibility.Comment);
                    return View(calculate);
                }


                var ClientRate = await Services.ApiServices.GetRateByAge(Eligibility);
                calculate.RateValue = ClientRate.RateValue;
                calculate.IPClient = IpAddress.GetIPClient;

                if (calculate.RateValue == 0)
                {
                    ModelState.AddModelError("", "No se pudo obtener la tasa para su edad");
                    return View(calculate);
                }

                ViewBag.Amount = await Services.ApiServices.GetCalculationFee(calculate);
                return View(calculate);
            }

            return View();
        }
    }
}