**Model Binding**
***

```
public class IndexModel : PageModel
{
  [BindProperty]
  public string Username { get; set; }
  
  [BindProperty]
  public bool IsActive { get; set; }
  
  // Example POST
  // https://localhost:8000?username=muhammad&IsActive=true
  public void OnPost()
  {
    // Username is "muhammad"
    // IsActive is true
  }
}
```
In model binding,

1. a page model retrieves data from an HTTP request,
1. converts the data to .NET types,and
1. updates the corresponding model properties.

It is enabled with the [BindProperty] attribute.
