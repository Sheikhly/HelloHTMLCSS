using HelloHTMLCSS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HelloHTMLCSS.Controllers
{
    public class HomeController : Controller
    {      


        public IActionResult Index()
        {
            return View();
        }

        
    }
}