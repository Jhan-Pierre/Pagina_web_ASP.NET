using app_ventas_501.Models;
using Microsoft.EntityFrameworkCore;

namespace app_ventas_501.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Personal> Personal { get; set; }
        public DbSet<Producto> Producto { get; set; }
    }
}
