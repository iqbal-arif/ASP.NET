**Saving Changes**
***
```
// Assuming Country is of type Country
// Assuming _context is of a type inheriting DbSet

public async Task<IActionResult> OnPostAsync(string id)
{
  // update
  _context.Attach(Country).State = EntityState.Modified;

  // insert
  await _context.Countries.AddAsync(Country);

  // delete
  Country Country = await _context.Countries.FindAsync(id);

  if (Country != null)
  {
    _context.Countries.Remove(Country);
  }

  // all three methods must be followed by savechanges
  await _context.SaveChangesAsync(); 
  
  return RedirectToPage("./Index");
}
```
The Entity Framework context DbSet member provides the Attach() method to update an existing record, the Add() method to insert a new record, and the Remove() method to delete an existing record. Any combination of multiple records can batched before saving.

Use the EF context SaveChanges() or SaveChangesAsync() methods to persist all inserted, updated, and deleted records to the database table.

**Updating Records
```
// Assuming Country is of type Country
// Assuming _context is of a type inheriting DbSet

public async Task<IActionResult> OnPostAsync(string id)
{
  if (!ModelState.IsValid)
  {
    return Page();
  }
  
  _context.Attach(Country).State = EntityState.Modified;

  await _context.SaveChangesAsync();
  
  return RedirectToPage("./Index");   
}
```
The Entity Framework context DbSet member provides the Attach() method to update an existing record in the in-memory representation of the corresponding database table. A batch of multiple records can also be updated in this fashion.

The record is passed from the browser in the <form> post back. In this case a Country member is declared with a [BindProperty] attribute so the entire record is passed back to the server.

Use the EF context SaveChanges() or SaveChangesAsync() methods to persist all updated records to the database table
