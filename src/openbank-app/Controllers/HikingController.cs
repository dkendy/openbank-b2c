using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Authorize(Policy = "HikingPolicy")]
    public class HikingController : Controller
    {
        // GET: HikingController
        public ActionResult Index()
        {
            return View();
        }

    }
}
