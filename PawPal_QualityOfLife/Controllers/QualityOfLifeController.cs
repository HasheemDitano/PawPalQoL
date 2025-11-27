using Microsoft.AspNetCore.Mvc;
using PawPalQoL.Models;

namespace PawPalQoL.Controllers
{
    public class QualityOfLifeController : Controller
    {
        // Show the form
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // Receive form and calculate
        [HttpPost]
        public IActionResult Index(QualityOfLifeModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Model already auto-calculates TotalScore
            int total = model.TotalScore;

            // Send result to the Result View
            return RedirectToAction("Result", new { score = total });
        }

        // Result page
        public IActionResult Result(int score)
        {
            ViewBag.Score = score;
            return View();
        }
    }
}
