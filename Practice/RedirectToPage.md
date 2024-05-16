**RedirectToPage()**
```
public class IndexModel : PageModel
{
  // Sends Privacy.cshtml
  public IActionResult OnPost()
  {
    return RedirectToPage("./Privacy");
  }
}
```
To redirect users to a different Razor page within the application, use RedirectToPage() in the page model’s handler methods.

   1. If a handler method calls RedirectToPage(), its return type is typically IActionResult or Task<IActionResult> (although others exist).
   2. The string argument passed to this method is a file path. "/Index" is a relative path and "./Index" is an absolute path.

