using Microsoft.EntityFrameworkCore;

public class CurrencyQueryDbContext : DbContext
{
    public DbSet<CurrencyQuery> CurrencyQueries { get; set; }

    public CurrencyQueryDbContext(DbContextOptions<CurrencyQueryDbContext> options)
        : base(options)
    {
    }
}
