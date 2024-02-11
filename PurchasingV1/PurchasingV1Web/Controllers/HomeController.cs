using Microsoft.AspNetCore.Mvc;
using PurchasingV1Web.Models;
using System.Diagnostics;

namespace PurchasingV1Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("/")]
        public IActionResult Index()
        {
            // Index sayfas�na �zel model veya i�levsellik ekleyebilirsiniz.

            return View();
        }

        [Route("/gizlilik")]
        public IActionResult Privacy()
        {
            // Privacy sayfas�na �zel model veya i�levsellik ekleyebilirsiniz.

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int? statusCode, string message)
        {
            // Hata sayfas�na hata kodunu ve mesaj�n� model ile g�nderiyoruz.
            // Hata loglama ekleyebilirsiniz.

            var errorViewModel = new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                StatusCode = statusCode,
                Message = message
            };

            // Daha detayl� hata i�leme ekleyebilirsiniz.

            return View(errorViewModel);
        }
    }
}