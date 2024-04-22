**OnPost()**
*****

The OnPost() handler method is invoked when a POST request is sent to a page. This usually happens when a user submits a form (an HTML <form> element).

Just like with OnGet(), the default behavior of an empty OnPost() method is to send the corresponding page. Without a return statement, this method also returns void.
```
public void OnPost()
{ }
```
Usually POST requests come with some information in the form of a query string. For example, say that a form at www.library.com/favorite asks for a book and an author:
```
<form method="post">
  <div class="form-group">
    <label for="Title">Title</label>
    <input type="text" class="form-control" id="Title" name="Title">
  </div>
  <div class="form-group">
    <label for="Author">Author</label>
    <input type="text" class="form-control" id="Author" name="Author">
  </div>
  <button type="submit" class="btn btn-primary">Submit</button>
</form>
```
Notice that each <input> has a name attribute — Title and Author, respectively.

In a browser it would look like:
```
Title: _______________________________
Author: _____________________________
Submit
```

If a user provided the input ***Where The Wild Things Are and Maurice Sendak***, the URL would look like this (**+** represents a space):
```
www.library.com/favorite?Title=Where+The+Wild+Things+Are&Author=Maurice+Sendak
```
OnPost() can capture the values in the query string via matching method parameters. To capture the above values, the method would look like this:
```
public void OnPost(string title, string author)
{
  Title = title;
  Author = author;
}
```
Those method parameters are matched case-insensitively; author or Author or aUTHOR would have worked.
