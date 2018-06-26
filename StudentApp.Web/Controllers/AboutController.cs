using System.Web.Mvc;

namespace StudentApp.Web.Controllers
{
    public class AboutController : StudentAppControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}