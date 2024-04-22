**OnGet()**
******

Page models handle HTTP requests, like GET and POST. We define their response using handler methods.

One of those handler methods is the OnGet() method. Whenever a user makes a GET request to a page, the page model’s OnGet() method is invoked.

For example, if a user navigates to localhost:8000/Archive in their browser:

   1. The browser sends a GET request to that URL.
   2. localhost:8000/Archive corresponds to Archive.cshtml so it receives the request.
   3. Archive.cshtml page references the ArchiveModel, so that class’ OnGet() method will be invoked.

It might sound complicated now, but it will feel natural by the end of this lesson. (You can even check this for yourself by exploring the relationship between localhost:8000/, Index.cshtml, and Index.cshtml.cs in the browser and editor.)

By default, an empty OnGet() method returns the corresponding view page. In the example above, the ArchiveModel.OnGet() corresponds to Archive.cshtml.

Since an empty OnGet() method has no return statement, the return type is void:
```
public void OnGet()
{ }
```
Within the method we can set values to properties, which can be displayed in the view page.
