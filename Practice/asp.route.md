**asp-route-{value}**
***
```
<a asp-page="About" asp-route-name="Joanne">About Joanne</a>
```
The asp-route-{value} attribute is used in <a> elements to add additional information to a URL route.

   1. {value} typically matches a property in a page model.
   2. The provided value will be added as a route segment or a query string, depending on how the route is defined.

If the above <a> tag is in a .cshtml file, it would be rendered as this HTML:
```
<a href="localhost:8000/About?name=Joanne">About Joanne</a>
```
However, if the About page has a route parameter, like @page {name}, then the same tag would be rendered as this HTML:
```
<a href="localhost:8000/About/Joanne">About Joanne</a>
```