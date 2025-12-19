using Microsoft.AspNetCore.Mvc;

namespace Asandului_Oana_Maria_Lab4.Controllers
{
    public class PredictionController : Controller
    {
        [HttpGet]
        public IActionResult Price()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Price(PricePredictionModel.ModelInput input)
        {
            var result = PricePredictionModel.Predict(input);
            ViewBag.Price = result.Score;   // acesta e prețul prezis
            return View(input);
        }
    }
}

