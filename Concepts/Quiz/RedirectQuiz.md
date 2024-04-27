Q1: Say you have a default Razor pages app with the below files. Which URL would you use to access the contents of Pages/About.cshtml?
Code
```
Pages/
|-- About.cshtml
|-- About.cshtml.cs
|-- Index.cshtml
|-- Index.cshtml.cs
```
A: /About
👏 Correct! The URL is defined by its corresponding file name, minus the .cshtml.

Q2: What attribute is used in page models to activate model binding?
A2: [BindProper]
👏 Correct! This is used above each property that will be bound to an input.

Q3: Say that FaqModel is associated with the /FAQ page. What will happen when a GET response is handled by this page model?
Code

public class FaqModel
{
  public void OnGet()
  {
    IActionResult redirect = RedirectToPage("/Index");
  } 
}
A3: It will return the /FAQ page.

Although RedirectToPage() is used in the method, the result is not returned, so the default /FAQ page will still be used.