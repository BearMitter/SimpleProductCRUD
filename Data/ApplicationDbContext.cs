using Microsoft.EntityFrameworkCore;
using SimpleProductCRUD.Models;

namespace SimpleProductCRUD.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();
}
