using System.Web.Mvc;

namespace UnitTest_Practices_MVC.Controllers
{
    public class CalculationController : Controller
    {

        // GET: Calculation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Calculation/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
