using Microsoft.AspNetCore.Mvc;
using PurchasingV1Web.Models;

namespace PurchasingV1Web.Controllers
{
    public class IslemController : Controller
    {
        private readonly PurchasingV1WebContext _dbContext;

        public IslemController(PurchasingV1WebContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Ara(string barkod)
        {
            if (string.IsNullOrEmpty(barkod))
            {
                return View(); // Barkod yok ise View'a yönlendir
            }

            var islem = await _dbContext.Islems.FindAsync(barkod);

            var model = new IslemViewModel
            {
                Islem = islem,
                AramaBarkodu = barkod
            };

            if (islem == null)
            {
                return View("IslemBulunamadi", model); // Arama sonucu bulunamazsa farklı View'a yönlendir
            }

            return View(model); // ViewModel'i View'a gönder
        }
    }
}