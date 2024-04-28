Q1: Say you have a default Razor pages app with the below files. Which URL would you use to access the contents of Pages/About.cshtml?

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
```
public class FaqModel
{
  public void OnGet()
  {
    IActionResult redirect = RedirectToPage("/Index");
  } 
}
```
A3: It will return the /FAQ page.

Although RedirectToPage() is used in the method, the result is not returned, so the default /FAQ page will still be used.
👏 Correct! Although RedirectToPage() is used in the method, the result is not returned, so the default /FAQ page will still be used.

Q4: Complete this method definition correctly.

```
public class AboutModel
{
  public string TeamMember { get; set; }

  public void OnGet(string member)
  {
    TeamMember = member;
  }
}
```
A4: This method is synchronous and returns nothing, so its return type should be "void".

Q5: Use Tag Helpers so that the Razor markup renders as the desired HTML.
```
<!-- Desired HTML -->
<input name="Fries" id="Fries" value="0" >

<!-- Your Razor markup -->
<input 

asp-for=

"Fries" value="0" >
```
A5: 👏 You got it!

Q6: Fill in the below Razor markup so that the element’s href attribute will render as /Weather?forecast=tomorrow.
```
@page

<a asp-page="/Weather" asp-route-forecast="tomorrow">Tomorrow</a>
```
A6: asp-route-forecast corresponds to the forecast parameter in the URL.

Q7: Say that MissingModel is associated with the page /Missing. Fill in the code so that it will send a 404 status code in response to every GET request.
```
public class MissingModel
{
  public IActionResult OnGet()
  {
    return NotFound();
  }
}
```
A7:👏 You got it!

Q8: The Razor page Pages/Contact.cshtml is shown below. Fill in the code so that the URL has an additional parameter, like Contact/Sheila or Contact/Sueko or Contact/James.
```
@page {name};

@{
  ViewData["Title"] = "Contact";
}
```

A7: Using curly braces and a variable name after @page will append a parameter to the default URL. 

Q8: Complete this method definition correctly.


```
public class WeatherModel
{
  public string Forecast { get; set; }

  public async Task OnGetAsync()
  {
    Forecast = await GetForecastAsync();
  }
}
````
A8: This method is asynchronous and returns nothing, so its return type should be Task

Q9: Imagine that this code is in Pages/Rugs.cshtml.cs. What will be in the response when a GET request is handled by this page model?
```
public class RugsModel
{
  public void OnGet()
  {
    Debug.Log("OnGet() called");
  }
}
```
A9: The response will include the Razor page associated with this model.

👏 Correct! By default, a handler method with no return statement will send its corresponding page as a response.

Q10: Say that RetiredModel is associated with the page /Retired. Fill in the code so that it will send the /New page in response to every GET request.
```
public class RetiredModel
{
  public IActionResult OnGet()
  {
    return Page(/New);
  }
}
```
A10: RedirectToPage() will return the page matching its argument. In this case that’s /New.

Q11: The Razor page Pages/Contact.cshtml is shown below. Fill in the code so that the page is made available at /Contact/Me.
```
@page "/"

@{
  ViewData["Title"] = "Contact";
}
```
A11: Adding a plain string after @page will append it to the default URL. It must not have a slash ("Contac/Me")

Q12: Say that ContactModel is associated with the page /Contact. Fill in the code so that it will send the /Contact page in response to every GET request.
```
public class ContactModel
{
  public IActionResult OnGet()
  {
    return Page();
  }
}
```
A12: 👏 You got it!

Q13: Say that a user is submitting a form on our delivery site, built with ASP.NET. The form generates a POST request and it is on the /Order page, which is associated with the OrderModel. What method will be invoked when the form is submitted?

A13: OrderModel.OnPostAsync()

👏 Correct! When a page receives a POST request, the corresponding page model’s OnPost() or OnPostAsync() method is invoked.

Q14: Say /Order is associated with OrderModel and a POST request is made to the below URL. What would Milkshakes be set to?
```
// POST request sent to:
// https://restaurant.net/Order?shakes=3&fries=1

public class OrderModel
{
  public int Fries { get; set; }
  public int Milkshakes { get; set; }

  public void OnPost(int fries, int shakes)
  {
    Fries = fries;
    Milkshakes = shakes;
  }
}
```
A14: 3 👏 Correct! The shakes value in the URL matches the shakes method parameter.

Q15: Say that a user is browsing pages on my-portfolio.com, built with ASP.NET. They are about to go to the /Projects page, which is associated with the ProjectsModel. What method will be invoked when they enter this URL in their browser?
```
https://my-portfolio.com/Projects/
```
A15: ProjectsModel.OnGetAsync()

👏 Correct! When a page receives a GET request, the corresponding page model’s OnGet() or OnGetAsync() method is invoked.

Q16: Use Tag Helpers so that the Razor markup renders as the desired HTML.
```
<!-- Desired HTML -->
<input name="Fries" id="Fries" value="0" >

<!-- Your Razor markup -->
<input asp-for="Fries" value="0" >

A16: 👏 You got it!