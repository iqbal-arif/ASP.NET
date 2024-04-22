**asp-route-{value}**
****

The Input Tag Helper, with asp-for, allows us to easily create a form that submits data with a POST request.

What Tag Helper and attribute(s) would help us with GET requests?

Similarly, the Anchor Tag Helper, with asp-page and asp-route-{value} attributes, allows us to create <a> links that submit data with a GET request.

  1.  asp-page — Sets an anchor tag’s href attribute value to a specific page.
  2.  asp-route-{value} — Adds route values to an href. The {value} placeholder is interpreted as a potential route parameter.

This markup in a view page…
```
<a asp-page="./Authors" asp-route-fullname="Roald Dahl">Roald</a>
```
…would render as this HTML…
```
<a href="./Authors?fullname=Roald+Dahl">Roald</a>
```
Like before, we can capture the query values via method parameters:
```
public void OnGet(string fullname)
{ }
```
Technically we could also use model binding with the attribute [BindProperty(SupportsGet=true)] but we generally avoid that because allowing users to set values in GET requests can be dangerous. If GET requests can set attributes, then it would be too easy to mistakenly edit our app’s data by browsing to a URL. We prefer to set attributes in POST requests because they have built-in security from ASP.NET.

To recap: Anchor Tag Helpers generate GET requests. They use asp-page and asp-route-{value}:
```
<a asp-page="./Authors" asp-route-fullname="Roald Dahl">Roald</a>
```
Input Tag Helpers (along with a form) generate POST requests. They use asp-for:
```
<input asp-for="Title">
```