using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Quality_of_Life.Models;

namespace Quality_of_Life.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Redirect to Quality of Life assessment as the main page
            return RedirectToAction("Index", "QualityOfLife");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
