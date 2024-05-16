**Page()**
```
public class AboutModel : PageModel
{
  // Sends About.cshtml
  public IActionResult OnGet()
  {
    return Page();
  }
}
```
To return the view page associated with a page model, use Page() in the page model’s handler methods.

  1.  This happens implicitly if the handler method has a void return type
  2.  If a handler method calls Page(), its return type is typically IActionResult or Task<IActionResult> (although others exist).

