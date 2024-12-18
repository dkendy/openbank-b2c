using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Authorize(Policy = "ReadingPolicy")]

    public class ReadingController : Controller
    { 

        // GET: ReadingController
        public ActionResult Index()
        {
            return View();
        }

    }
}
