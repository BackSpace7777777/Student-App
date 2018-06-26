using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace StudentApp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : StudentAppControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}