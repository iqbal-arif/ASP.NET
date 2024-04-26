**RedirectToPage()**
****

In the past, our handler methods had a void return type:

```
public void OnGet() {}
```

To perform redirection we need our methods to return an object. This object will determine what kind of response is sent back to the browser.

This object can be any type that implements the IActionResult interface. There are a few types that do, but we don’t need to dive into those. All we need to know is that the methods in this lesson return something that implements IActionResult.

Let’s start with RedirectToPage(). For basic redirection, call it with a string argument and return the result. The string will represent the destination page, written like the URL segment, like "/Privacy" or "/About/Me".

Here’s an example handler method that always redirects learners to the checkout page:
```
public IActionResult OnPost()
{
  return RedirectToPage("/Checkout");
}
```
Note that the / (slash) makes the path relative to the Pages folder. In other words, this takes the user to the contents in Pages/Checkout.cshtml. Removing the slash makes the path relative to the current page.

Optional information: For those of you already familiar with HTTP status codes, RedirectToPage() produces an HTTP status code of 302, and the browser knows where to browse to by using information in the response header.
