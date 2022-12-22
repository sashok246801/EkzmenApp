using EkzmenApp;
using Microsoft.EntityFrameworkCore;

public class ApplicationContext : DbContext
{
    public DbSet<Kuk> Kuk { get; set; }
    public DbSet<PrKuk> PrKuk { get; set; }
    public DbSet<Gan> Gan { get; set; }
    public DbSet<Stel> Stel { get; set; }
    public DbSet<Izd> Izd { get; set; }
    public DbSet<AvKuk> AvKuk { get; set; }
    public DbSet<Av> Av { get; set; }
    public DbSet<Pr> Pr { get; set; }
    public DbSet<Ot> Ot { get; set; }


    public ApplicationContext() 
    {
        Database.EnsureCreated();
    } 

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"data source =323-3\SQLEXPRESS; initial catalog = Читай-город; integrated security = True; MultipleActiveResultSets = True; App = EntityFramework");
    }
}