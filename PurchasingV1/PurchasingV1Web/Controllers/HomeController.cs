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
            // Index sayfasýna özel model veya iþlevsellik ekleyebilirsiniz.

            return View();
        }

        [Route("/gizlilik")]
        public IActionResult Privacy()
        {
            // Privacy sayfasýna özel model veya iþlevsellik ekleyebilirsiniz.

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int? statusCode, string message)
        {
            // Hata sayfasýna hata kodunu ve mesajýný model ile gönderiyoruz.
            // Hata loglama ekleyebilirsiniz.

            var errorViewModel = new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                StatusCode = statusCode,
                Message = message
            };

            // Daha detaylý hata iþleme ekleyebilirsiniz.

            return View(errorViewModel);
        }
    }
}