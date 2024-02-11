using Microsoft.EntityFrameworkCore;

namespace PurchasingV1Web.Models
{
    public class PurchasingV1WebContext : DbContext
    {
        internal object Islem;

        public PurchasingV1WebContext()
        {
        }

        public PurchasingV1WebContext(DbContextOptions<PurchasingV1WebContext> options)
            : base(options)
        {
        }

        public DbSet<Islem> Islems { get; set; }
    }
}