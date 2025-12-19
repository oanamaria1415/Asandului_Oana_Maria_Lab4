using Microsoft.AspNetCore.Mvc;

namespace Asandului_Oana_Maria_Lab4.Controllers
{
    public class PredictionController : Controller
    {
        // GET: /Prediction/Duration
        [HttpGet]
        public IActionResult Duration()
        {
            return View();
        }

        // POST: /Prediction/Duration
        [HttpPost]
        public IActionResult Duration(PricePredictionModel.ModelInput input)
        {
            var result = PricePredictionModel.Predict(input);

            // Score = durata prezisă (secunde) pentru modelul WebApi2
            ViewBag.DurationSeconds = result.Score;
            ViewBag.DurationMinutes = result.Score / 60f;

            return View(input);
        }
    }
}
