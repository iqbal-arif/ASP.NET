**Database Context**
```
using Microsoft.EntityFrameworkCore;

public class CountryContext : DbContext
{
  public CountryContext(DbContextOptions<CountryContext> options)
      : base(options)
  {
  }

  public DbSet<Country> Countries { get; set; }
  public DbSet<Continent> Continentselies on the Microsoft.En
  protected override void OnModelCreating(ModelBuilder modelBuild { get; set; }
at provides connectivity to an external database for an application. It rer)
  {
    modelBuilder.En  tity<Country>().ToTable("Country");
    modelBuilder.Entity<Continent>().ToTable("Continent");
  }
}
```
The Entity Framework database context is a C# class that provides connectivity to an external database for an application. It relies on the Microsoft.EntityFrameworkCore library to define the DB context which maps model entities to database tables and columns.

The DbContextOptions are injected into the context class via the constructor. The options allow configuration changes per environment so the Development DB is used while coding and testing but the Production DB would be referenced for real work.

The DbSet is an in-memory representation of a table or view which has a number of member methods that can return a List<T> of records or a single record.
