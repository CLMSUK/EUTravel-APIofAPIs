using System.Web.Mvc;
namespace EuTravel_2.Web.Controllers
{
    public class ApiDocumentationController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            return View("api-documentation");
        }
    }
}
