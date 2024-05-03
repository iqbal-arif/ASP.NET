**Finding Records**
***
```
// Assuming Country is of type Country
// Assuming _context is of a type inheriting DbSet

public async Task<IActionResult> OnGetAsync(string id)
{
  if (id == null)
  {
    return NotFound();
  }

  Country Country = await _context.Countries.FindAsync(id);
  
  return Page();
}
```

The Entity Framework context DbSet member provides
1. the Find() and FindAsync() methods to retrieve an existing record from the in-memory representation of the database table.
1. Assign the result of this method to a local member in the page model.

This method generates the appropriate SQL syntax needed to access the record in the database table.
