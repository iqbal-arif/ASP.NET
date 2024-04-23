**Review**
****

Well done! We’ve covered a lot of page model concepts. Let’s review:

  1.  When a GET request is made to a page, the OnGet() or OnGetAsync() method from its page model is invoked.
  2.  When a POST request is made to a page, the OnPost() or OnPostAsync() method from its page model is invoked.
  3.  URL query string values can be accessed via a method’s parameters.
  4.  URL query string values can also be accessed via model binding, which is activated using [BindProperty].
  5.  The asp-for attribute in Input Tag Helpers connects an <input> element to a model property.
  6.  The asp-route-{value} attribute in Anchor Tag Helpers adds additional information to a link.
  7.  Synchronous handler methods, like OnGet() and OnPost(), with no return statement will have a return type of void.
  8.  Asynchronous handler methods, like OnGetAsync() and OnPostAsync(), with no return statement will have a return type of Task.

If you’d like to see other examples of handler methods, look at the first few sections of this introduction to Razor Pages by Microsoft ***https://learn.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-8.0&tabs=visual-studio*** and check out the Handler Methods section on Learn Razor Pages.***https://www.learnrazorpages.com/razor-pages/handler-methods***
