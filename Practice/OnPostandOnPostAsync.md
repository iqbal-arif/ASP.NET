**OnPost() & OnPostAsync()**
***
```
public class IndexModel : PageModel
{
  public string Message { get; set; }

  public void OnPost()
  {
    Message = "OnPost() called!";
  }
}
```
When a page model receives a POST request, its OnPost() or OnPostAsync() method is invoked. This typically happens when a user submits a form on the page model’s corresponding view page.

A page model must have either OnPost() or OnPostAsync(). It cannot have both.
