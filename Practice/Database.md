**Database Connection String**
***
```
{
  "ConnectionStrings": {
    "CountryContext": "Data Source=Country.db"
  }
}
```
The Entity Framework context depends on a database connection string that identifies a physical database connection. It is typically stored in **appsettings.json**. You can define multiple connection strings for different environments like Development, Test, or Production.

Each database product has specific requirements for the syntax of the connection string. This might contain the database name, user name, password, and other options.
***

**DbSet Type**
***
```
using Microsoft.EntityFrameworkCore;

public class CountryContext : DbContext
{
  public CountryContext(DbContextOptions<CountryContext> options)
      : base(options)
  {
  }

  public DbSet<Country> Countries { get; set; }
  public DbSet<Continent> Continents { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Country>().ToTable("Country");
    modelBuilder.Entity<Continent>().ToTable("Continent");
  }
}
```
1. The Entity Framework type DbSet represents a database table in memory.
2. It is typically used with a <T> qualifier.
3. The type, or T, is one of your database model classes.
4. The ModelBuilder binds each database table entity to a corresponding DbSet.

DbSet has a number of member methods that can return a List<T> of records or a single record

***

**Deleting Records**
***

// Assuming Country is of type Country
// Assuming _context is of a type inheriting DbSet

public async Task<IActionResult> OnPostAsync(string id)
{
  if (id == null)
  {
    return NotFound();
  }

  Country Country = await _context.Countries.FindAsync(id);

  if (Country != null)
  {
    _context.Countries.Remove(Country);
  }

  await _context.SaveChangesAsync(); 
  
  return RedirectToPage("./Index");
}

The Entity Framework context DbSet member provides the Remove() method to delete an existing record from the in-memory representation of the database table. Any combination of multiple record deletions can be batched before saving.

Use the EF context SaveChanges() or SaveChangesAsync() methods to persist all deletions to the database table.
