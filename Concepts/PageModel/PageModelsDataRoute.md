**Re-Introduction To Page Models**
*****

When you want to take your website to the next level, you need to do more than display text and images. You need to handle data and route requests. That’s where page models come in!

Let’s review some points about ASP.NET Core and the page-focused Razor Pages framework:

   1. In view pages (.cshtml files), Razor syntax lets us mix C# and HTML code in one file so that we can make flexible templates.
   2. In page models (.cshtml.cs files), we use C# code and special PageModel classes to maintain data and handle different actions, like GET and POST requests.

This lesson will focus on page models and some of the things we can do with them, such as:

  1.  Respond to requests using the OnGet() and OnPost() methods
  2.  Respond to requests using the asynchronous OnGetAsync() and OnPostAsync() methods
  3.  Use model binding to share data between view pages and page models

