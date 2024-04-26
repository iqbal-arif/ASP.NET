**Review**
***

You’re on your way to becoming an ASP.NET master! In this lesson we learned some methods and types that are used to redirect users to pages:

   1. When a handler method has no return statement, it will send the associated page as a response.
   2. When a redirect method is used in a handler method, it must return the type IActionResult (or some type that implements the interface) or Task<IActionResult> if asynchronous.
   3. Page() causes the server to render the Razor view page associated with the current page model.
   4. RedirectToPage() causes the server to render the Razor view page described in the method argument. Generates a 302 HTTP status code.
   5. NotFound() causes the server to send a “Status 404 Not Found” response.

   These are just a few common redirection methods. You can find a full list of them defined within the PageModel type.
   ```
   https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.razorpages.pagemodel?view=aspnetcore-8.0#methods
   ```
   A good one to start with is Redirect(), which works similarly to RedirectToPage(), but can redirect to URLs outside of your own application.

You can find further examples of redirection methods in the Microsoft tutorials
```
https://learn.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-8.0&tabs=visual-studio#url-generation-for-pages
```
and a nice list of common redirection methods on Learn Razor Pages.
```
https://www.learnrazorpages.com/razor-pages/action-results
```
   