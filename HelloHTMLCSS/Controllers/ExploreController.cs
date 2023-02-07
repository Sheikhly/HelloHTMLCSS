using Microsoft.AspNetCore.Mvc;

namespace HelloHTMLCSS.Controllers
{
    public class ExploreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
