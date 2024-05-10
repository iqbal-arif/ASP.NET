**asp-for**
***
```
<!-- In .cshtml file -->
Enter a username: <input asp-for="Username" />
```
The asp-for attribute is used to connect an <input> element to a page model property.

The above example would be connected to a Username property in the page model:
```
public class IndexModel : PageModel
{
  [BindProperty]
  public string Username { get; set; }
}
```
In the rendered HTML, attributes like type, id, and name will be added to the <input> tag:
```
Enter a username:
<input type="text" id="Username" name="Username" >
```