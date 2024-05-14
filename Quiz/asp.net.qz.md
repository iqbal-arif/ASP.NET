Q1: Say you have a default Razor pages app with the below files. Which URL would you use to access the contents of Pages/About.cshtml?
```
Pages/
|-- About.cshtml
|-- About.cshtml.cs
|-- Index.cshtml
|-- Index.cshtml.cs
```
A1: /About
👏 Correct! The URL is defined by its corresponding file name, minus the .cshtml.

Q2: Say that a user is browsing pages on my-portfolio.com, built with ASP.NET. They are about to go to the /Projects page, which is associated with the ProjectsModel. What method will be invoked when they enter this URL in their browser?
```
https://my-portfolio.com/Projects/
```
A2: ProjectModel.OnGetAsync()

👏 Correct! When a page receives a GET request, the corresponding page model’s OnGet() or OnGetAsync() method is invoked.

Q3: The Razor page Pages/Contact.cshtml is shown below. Fill in the code so that the URL has an additional parameter, like Contact/Sheila or Contact/Sueko or Contact/James.
```
@page "{name}"

@{
  ViewData["Title"] = "Contact";
}
```
A3: {name} 👏 You got it!

Q4: Use Tag Helpers so that the Razor markup renders as the desired HTML.
```
<!-- Desired HTML -->
<input name="Fries" id="Fries" value="0" >

<!-- Your Razor markup -->
<input asp-for= "Fries" value="0" >
```
Answer Choices
In Input Tag Helpers,asp-for attributes replace both name and id attributes.

Q5: What attribute is used in page models to activate model binding?
A5: [BindProperyt]
👏 Correct! This is used above each property that will be bound to an input.

Q6: Fill in the below Razor markup so that the element’s href attribute will render as /Weather?forecast=tomorrow.
```
@page

<a asp-page="/Weather" asp-route-forecast="tomorrow">Tomorrow</a>
```
A6: asp-route-forecast corresponds to the forecast parameter in the URL.

Q7: The Razor page Pages/Contact.cshtml is shown below. Fill in the code so that the page is made available at /Contact/Me.
```
@page "Me"

@{
  ViewData["Title"] = "Contact";
}
```
A7: Adding a plain string after @page will append it to the default URL. It must not have a slash (/).

Q8: Complete this method definition correctly.
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
A8: You got it!

Q9: Say /Order is associated with OrderModel and a POST request is made to the below URL. What would Milkshakes be set to?
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
A9: 3 👏 Correct! The shakes value in the URL matches the shakes method parameter.

Q10: Complete this method definition correctly.
```
public class WeatherModel
{
  public string Forecast { get; set; }

  public async Task OnGetAsync()
  {
    Forecast = await GetForecastAsync();
  }
}
```
A10: 👏 You got it!

Q11: Say that a user is submitting a form on our delivery site, built with ASP.NET. The form generates a POST request and it is on the /Order page, which is associated with the OrderModel. What method will be invoked when the form is submitted?
A11: OrderModel.OnPostAsync()

👏 Correct! When a page receives a POST request, the corresponding page model’s OnPost() or OnPostAsync() method is invoked.

Q12: Say that FaqModel is associated with the /FAQ page. What will happen when a GET response is handled by this page model?
```
public class FaqModel
{
  public void OnGet()
  {
    IActionResult redirect = RedirectToPage("/Index");
  } 
}
```
A12: It will return the /FAQ page.
👏 Correct! Although RedirectToPage() is used in the method, the result is not returned, so the default /FAQ page will still be used.

Q13: Use Tag Helpers so that the Razor markup renders as the desired HTML.
```
<!-- Desired HTML -->
<input name="Fries" id="Fries" value="0" >

<!-- Your Razor markup -->
<input asp-for="Fries" value="0" >
```
A13: 👏 You got it!

Q14: Complete this method definition correctly.
```
public class WeatherModel
{
  public string Forecast { get; set; }

  public async Task OnGetAsync()
  {
    Forecast = await GetForecastAsync();
  }
}
```
A14: 👏 You got it!

Q15: Say that a user is browsing pages on my-portfolio.com, built with ASP.NET. They are about to go to the /Projects page, which is associated with the ProjectsModel. What method will be invoked when they enter this URL in their browser?
```
https://my-portfolio.com/Projects/

```
A15: ProjectsModel.OnGetAsync()
👏 Correct! When a page receives a GET request, the corresponding page model’s OnGet() or OnGetAsync() method is invoked.