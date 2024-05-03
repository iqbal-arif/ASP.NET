**LINQ Queries**
***
```
using System.Linq;

var countries = from c in _context.Countries
          select c;

countries = countries.Where(c => c.Name.Contains("Russia"));

countries = countries.Where(c => c.ContinentID == 3);

countries = countries.OrderBy(c => c.Name);

List<Country> Countries = await countries.ToListAsync();
```
The Entity Framework DbSet entities can manage complex queries using C# LINQ syntax. This is referenced from the System.Linq library.

All of the Where() and OrderBy() clauses are evaluated in the final statement that calls ToListAsync(). EF evaluates all options and generates a SQL SELECT statement with corresponding WHERE and ORDERBY clauses.

