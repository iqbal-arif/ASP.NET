**Append URL Segments**
```
@page "segment"
```
In Razor view pages (.cshtml files), the @page directive can be used to add segments to a page’s default route. Use this feature by typing a string after @page.

For example, imagine the below code is from About.cshtml. Instead of /About, the new route would be /About/Me:
```
@page "Me"
```