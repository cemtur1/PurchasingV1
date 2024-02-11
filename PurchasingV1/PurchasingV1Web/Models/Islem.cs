
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PurchasingV1Web.Models;


namespace PurchasingV1Web.Models{

    public class Islem
    {
        [Key]
        public int S { get; set; }

        [Required(ErrorMessage = "Barkod numarası gereklidir")]
        [StringLength(50, ErrorMessage = "Barkod numarası 50 karakterden uzun olamaz")]
        public string Barkod { get; set; }

        [Required(ErrorMessage = "Konu gereklidir")]
        [StringLength(255, ErrorMessage = "Konu 255 karakterden uzun olamaz")]
        public string Konu { get; set; }

        [Required(ErrorMessage = "Talep tarihi gereklidir")]
        public DateTime TalepTarihi { get; set; }

        [Required(ErrorMessage = "Durum gereklidir")]
        [StringLength(50, ErrorMessage = "Durum 50 karakterden uzun olamaz")]
        public string Durum { get; set; }

        public string? Aciklama { get; set; }

        public static Islem GetIslemByBarkod(string barkod)
        {
            using (var db = new PurchasingV1WebContext())
            {
                return db.Islems.Find(barkod);
            }
        }
    }
}
