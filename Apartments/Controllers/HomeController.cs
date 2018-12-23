using Apartments.Models;
using System.Web.Mvc;

namespace Apartments.Controllers
{
    public class HomeController : Controller
    {
        ApartmentsContext db = new ApartmentsContext();

        public ActionResult Index()
        {
            var qwe = db.Clients.Find(1);
            ViewBag.QWE = qwe;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}