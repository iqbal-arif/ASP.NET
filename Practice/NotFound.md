**NotFound()**
```
public class EditModel : PageModel
{
  public async Task<IActionResult> OnGetAsync(int? id)
  {
    if (id == null)
    {
      return NotFound();
    }
    
    // do something with id here
    
    return Page();
  }
}
```
To send a “Status 404 Not Found” response, use **NotFound()** in the page model’s handler methods.

   1. If a handler method calls NotFound(), its return type is typically IActionResult or Task<IActionResult> (although others exist).

