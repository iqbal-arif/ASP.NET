**Add Optional Route Templates**
***

We can make route values optional with a question mark ?.

For example, this defines an optional title template:
```
@page "{title?}"
```
In order to capture that in a method parameter, you’ll need to also use the question mark there:
```
public void OnGet(string? title) { }
```
When combining with an if - else statement, your handler method can change behavior based on whether the value was provided:
```
public void OnGet(string? title)
{
  if (String.IsNullOrEmpty(title))
  {
    IsGeneralDisplay = true;
  }
  else
  {
    Title = title.Value;
    IsGeneralDisplay = false;
  }
}
```
In the if condition, we use String.IsNullOrEmpty() to check the value of title. It returns true if the title is not provided in the URL or it is empty (""). For non-string types, we use the HasValue property. For example:
```
public void OnPost(bool? b)
{
  if (b.HasValue)
  {
    // Access b.Value
  }
  else
  {
    // b is null
  }
}
```
You can read more about nullable types in the Microsoft documentation.
