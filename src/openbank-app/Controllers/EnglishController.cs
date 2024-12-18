using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace

{
    [Authorize(Policy = "EnglishPolicy")]
    public class EnglishController : Controller
    {
        // GET: EnglishController
        public ActionResult Index()
        {
            return View();
        }

    }
}
