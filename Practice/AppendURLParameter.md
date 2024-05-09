**Append URL Parameters**
***
```
@page {param}
```
In Razor view pages (.cshtml files), the @page directive can be used to add parameters to a page’s route.

  1.  The parameter(s) must be in between curly braces { } after @page.
  2.  Constraints, like int or alpha, can be added using colons :.
  3.  A parameter can be marked optional using a question mark ?.

Imagine the below code is from Book.cshtml. Instead of /Book, the new route could be /Book/0 or Book/1 or Book/2 etc.:
```
@page "{id:int}"
```
Imagine the below code is from House.cshtml. The new route could be /House or House/small or House/big etc.:
```
@page "{size?}"
```
Imagine the below code is from Song.cshtml. Instead of /Song, the new route would be /Song or Song/0 or Song/1 etc.:
```
@page "{song:int?}"
```