**Void Handler Methods**
***
```
public class IndexModel : PageModel
{
  public string Username { get; set; }

  public void OnGet()
  { 
    Username = "n/a";
  }

  public void OnPost(string username)
  {  
    Username = username;
  }
}
```

In a page model, synchronous handler methods like OnGet() and OnPost() that have no return statement will have a return type of void.

This results in the current page being rendered in response to every request.
