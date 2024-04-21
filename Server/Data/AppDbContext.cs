using DevExpress.Server.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevExpress.Server.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<DimCustomer> DimCustomer { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
