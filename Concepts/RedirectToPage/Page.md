**Page()**
***

Say that we only want to redirect in some cases. Otherwise we want to have the original response, which included the current page.

Now that our handler methods are returning IActionResult values, we need a way to return the current page. The answer is calling and returning the Page() method.

Returning Page() will lead to the same behavior we saw when we had void handler methods (although we now have the flexibility to redirect as well).

These two methods have the same behavior:
```
public void OnGet()
{}
```
```
public IActionResult OnGet()
{
  return Page();
}
```