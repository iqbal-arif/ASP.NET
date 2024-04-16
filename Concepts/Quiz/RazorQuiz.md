Q1: If this code was included in a Razor view page, how would you display the value of the Title property inside a <header> tag?
```
@{
  ViewData["Title"] = "About";
}
```
A1: <header>@ViewData["Titel"]</header>
👏 Correct! You can access the value by using bracket notation with the key in quotation marks.

Q2: A model, UserModel, with a property named FullName is passed into a view page. How would you access and display that property?
```
A2: 
```
@page
@model UserModel

<div>
  <h1>Welcome back, @Model.FullName </h1>
</div>
```

Q3: What is the resulting HTML when this code runs on a view page?
```
@{ int num = 3; }
@if(num < 5)
{
  <h5>The number is less than 5!</h5>
} 
else
{
  <h5>The number is more than 5!</h5>
}
<h5>The number is @num</h5>
```

A3: 
```
The number is less than 5!
The number is 3
```
👏 Correct! num is less than 5 so the first code block is executed and its value is displayed since we’re prefixing the variable with the “@” sign.

Q4: What is Razor Pages?
A4: Razor Pages is a framework based on ASP.NET Core, it consists of Razor markup, C#, and HTML.
👏 Correct! Razor Pages is a lightweight framework that allow us to build web sites with clean separation of concerns.

Q5: This Layout page currently defines a header and footer. Fill in the code so that it renders a content page in-between the two.
A5: 
```
<p>This is header text</p>
@RenderBody()
<p>&copy; 2020 Codecademy. All rights reserved.</p>
```

Q6: 
A6:
```
@{int day = 1;}
@switch (day) {
case 1:
    <p>Saturday</p>
    break;
  case 2:
    <p>Sunday</p>
    break;
  default:
    <p>Weekday</p>
break;
}
```

Q7: What are Tag Helpers?
A7: Tag Helpers allow you to replace Razor's syntax with a more naturl HTML-Like syntax to run server-side code.
👏 Correct! Tag Helpers help us enhance existing HTML elements in our views by providing us with numerous server-side attributes.

Q8: Fill in Profile.cshtml so that it uses the model defined in Profile.cshtml.cs.
```
Profile.cshtml.cs:

namespace App.Pages
{
  public class ProfileModel : PageModel
  {
    …
  }
}

Profile.cshtml:
Code

@page

@model ProfileModel
```

Q9: What is the difference between _ViewImports.cshtml and _ViewStart.cshtml?
A9: _ViewImports.cshtml is used to provide ***using*** statements throughout all your view pages.
_ViewStart.cshtml is used for code to be executed as soon as a page is rendered.

Q10: What will be displayed on the view page given the following code?
```
@page

@{
  int i = 0;
}

@while (i < 3)
{
  i += 1;
  <p>@i</p>
}
```
A10: 1,2,3 👏 Correct! The loop breaks before the variable, i, reaches 3. It’s incremented by 1 before being printed and uses the “@” sign to display its value.

Q11: Use a foreach loop to iterate over animals and display each element in an <li> tag.
A11:
```
@{
  List<string> animals = new List<string>() 
  {
    "Dog",
    "Cat",
    "Cow",
    "Mouse"
  };
}

<ul>
  @foreach(string animal in animals)
  {
    <li>@animal</li>
  }
</ul>
```

Q12: In order for a file to act as a Razor view page, what directive must be added on the first line of the file?
A12: @page 👏 Correct! @page is the first line of code for every view page in order for the file to be treated as a Razor Page.

Q13: Fill in the code in order to iterate over all the items in the list fruits.
A13:
```
@{
  List<string> fruits = new List<string>()
  {
    "Apple",
    "Pear",
    "Banana",
    "Grapes"
  };
}

<p>My favorite fruits are:</p>
<ul>
  @for(int i =0; i < fruits.Count; i++)
  {
    @fruits[i]
  }
</ul>
```