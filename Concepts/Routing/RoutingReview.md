**Review**
****

Well done! Instead of ugly URLs like:
```
localhost:8000/Movies/Horror/Create?title=Spooky+Ghosts&length=120
```
You can now re-define them like:
```
localhost:8000/AddScaries/Spooky+Ghosts/120
```
In this lesson you learned:

   1. Typing a string after the @page directive will edit the page’s default route.
   2. Typing parameters within curly braces after the @page directive will define a route template.
   3. Route values can be made optional with a question mark ?.
   4. Route values can be constrained using the colon syntax and keyword constraints.
   5. The asp-route-{value} attribute can add additional information to an <a> element’s href attribute, either in the form of an additional route segment or query string, depending on how the route template is defined.
```
<!-- No URL segments -->
@page
<!-- Edit the default route -->
@page "/Days"
<!-- Add a route template -->
@page "/Days/{day}"
<!-- Constrain route value -->
@page "/Days/{day:int}"
<!-- Make route value optional -->
@page "/Days/{day:int?}"
```