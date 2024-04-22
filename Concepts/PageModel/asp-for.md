asp-for
9 min

So far, we’ve built an HTML form in the view page. When submitted it sends a URL query string to our app according to the name attributes of the form. We captured the query values first using method parameters, then using model binding.

We can make that first step (writing a form) even easier using Tag Helpers. We expect you to be familiar with the general concept of Tag Helpers, but we’ll show you a new use for them here.

Instead of using the name and id attributes in each <input> element, we’ll use the asp-for attribute:

Take this Input Tag Helper, which uses the asp-for attribute:
```
<input asp-for="Author">
```
It will render as this HTML:
```
<input type="text" name="Author" id="Author">
```
Why is this Tag Helper better than basic HTML? The benefits will become clearer as we create more advanced properties, but:

  1.  It saves you the hassle of writing HTML attributes.
  2.  Integrated Development Environments (IDEs), like Visual Studio, can check for errors before you run the code.
  3.  Changes to the property (in a model) are automatically carried into the view page.
  4.  Advanced settings on properties, such as data validation, are converted into additional HTML attributes. We won’t be covering those yet, so we won’t see this benefit in this lesson.

