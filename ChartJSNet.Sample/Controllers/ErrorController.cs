using System.Web.Mvc;

namespace ChartJS.NET.Sample.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Http404()
        {
            Response.StatusCode = 404;

            return View();
        }
    }
}