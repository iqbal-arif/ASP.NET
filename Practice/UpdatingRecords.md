**Updating Records**
***
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
1.The Entity Framework context DbSet member provides the ***Attach() method*** to update an existing record in the in-memory representation of the corresponding database table. A batch of multiple records can also be updated in this fashion.

2.The record is passed from the browser in the ***<form>*** post back. In this case a Country member is declared with a ***[BindProperty]*** attribute so the entire record is passed back to the server.

3.Use the EF context ***SaveChanges()*** or ***SaveChangesAsync()*** methods to persist all updated records to the database table