using project.control.alt.defeat.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace project.control.alt.defeat.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        { }

        public DbSet<Item> Items {get; set; }
    }
}
