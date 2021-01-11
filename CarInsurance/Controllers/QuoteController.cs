using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class QuoteController : Controller
    {
        // GET: Quote
        public ActionResult QuoteCalculator()
        {
            return View();
        }
    }
}