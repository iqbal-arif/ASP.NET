**Introduction to Redirection**
***

So far, every handler method has rendered the same view page. For example, OnGet() in Index.cshtml.cs will always send a response with Index.cshtml, and OnPost() in About.cshtml.cs will always send a response with About.cshtml.

Sometimes we want to redirect users to a different page.

  1.  A blog website has a “Posts” page showing blog posts and a separate “Create” page. After submitting on “Create”, the user should be redirected to the list of blog posts on “Posts”.

  2.  A page on your education website has become outdated, and you add a new one to replace it. Learners requesting the old page should be redirected to the newer version of the page (assuming you have to keep the old page for those who are half-way through the content).

  3.  A user submitted a request for non-existent data on your site and you want to show them a “Not Found” page.

This lesson will show you some useful methods to satisfy those examples, including:

  1.  RedirectToPage()
  2.  NotFound()
  3.  Page()

