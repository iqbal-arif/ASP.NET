**OnGet() & OnGetAsync()**
***
```
public class ZooModel : PageModel
{
  public string FavoriteAnimal { get; set; }

  // Sets FavoriteAnimal when page is requested
  public void OnGet()
  {
    FavoriteAnimal = "Hippo";
  }
}
```
When a page model receives a GET request, its OnGet() or OnGetAsync() method is invoked. This typically happens when a user navigates to the page model’s corresponding view page.

A page model must have either OnGet() or OnGetAsync(). It cannot have both.
