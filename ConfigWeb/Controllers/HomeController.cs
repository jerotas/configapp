using System.Configuration;
using System.Web.Mvc;
using ConfigWeb.Models;

namespace ConfigWeb.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            var model = new HomeModel {
                DatabaseName = ConfigurationManager.AppSettings["DatabaseName"],
                ReleaseMode = ConfigurationManager.AppSettings["ReleaseMode"]
            };

            return View(model);
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}