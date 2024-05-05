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

**const numberDigits = (num) => {

  const digitCount = num.toString();

  const numIncludes = digitCount.includes('-');



  if (numIncludes === true) {

    return `The number is: ${num}`;

  } else if (digitCount.length === 1) {

    return `One digit: ${num}`;

  } else if (digitCount.length === 2) {

    return `Two digits: ${num}`;

  } else if (digitCount.length === 3) {

    return `The number is: ${num}`;

  }

};

y = -235;

newNum = y.toString();

const r = newNum.includes('-');

console.log(r);



console.log(numberDigits(100));