using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PurchasingV1Web.Models;
using System.Linq;

namespace PurchasingV1Web.Controllers
{
    public class AramaController : Controller
    {
        private readonly PurchasingV1WebContext _context;

        public AramaController(PurchasingV1WebContext context)
        {
            _context = context;
        }

        public IActionResult Arama(string barkod)
        {
            
            var islem = (_context.Islem as IQueryable<Islem>).FirstOrDefault(x => x.Barkod == barkod);

            // 'Islem' türünde bir değişken tanımlayın
            Islem bulunanIslem = islem;

            if (bulunanIslem == null)
            {
                return View("IslemBulunamadi");
            }

            return View(bulunanIslem);
        }

        public IActionResult IslemBulunamadi()
        {
            return View();
        }
    }
}