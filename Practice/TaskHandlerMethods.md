**Task Handler Methods**
***
```
public class IndexModel : PageModel
{
  public string Users { get; set; }
  private UserContext _context { get; set; }

  public IndexModel(UserContext context)
  {
    _context = context;
  }

  // Task return type
  public async Task OnGetAsync()
  { 
    Users = await _context.Users.ToListAsync();
  }

  // Task return type
  public async Task OnPostAsync(string username)
  {  
    _context.Users.Add(username);
    await _context.SaveChangesAsync();
  }
}
```
In a page model, asynchronous handler methods like OnGetAsync() and OnPostAsync() that have no return statement will have a return type of Task.

This results in the current page being rendered in response to every request.
