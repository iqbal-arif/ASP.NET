**asp-route-{value} revisited**
****

Remember the Anchor Tag Helper? It�s the one with asp-page and asp-route-{value} attributes that allows us to create <a> links that submit data with a GET request.

Previously we saw how the resulting asp-route-{value} appended a query string to the URL:
```
<a asp-page="./Blogpost" asp-route-id="4">ID 4</a>
```
The above Razor syntax would render as this HTML:
```
<a href="./Blogpost?id=4">ID 4</a>
```
What happens if our URL template accepts URL segments instead of a query string? It would be defined like this in Blogpost.cshtml:

```@page {id}```

Here we find another advantage of Tag Helpers over plain HTML: it automatically formats URLs to match the defined template.

When we use URL segments instead of query strings, the old Anchor Tag Helper�
```
<a asp-page="./Blogpost" asp-route-id="4">ID 4</a>
```
�would render as this HTML�
```
<a href="./Blogpost/4">ID 4</a>
```
In review:

  1.  asp-page � Sets an anchor tag�s href attribute value to a specific page
  2.  asp-route-{value} � Appends route values to the generated href attribute, either as query string values or URL segments (depending on the route template). {value} is the name of the parameter.

