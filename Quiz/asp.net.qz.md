Q1: Say you have a default Razor pages app with the below files. Which URL would you use to access the contents of Pages/About.cshtml?
```
Pages/
|-- About.cshtml
|-- About.cshtml.cs
|-- Index.cshtml
|-- Index.cshtml.cs
```
A1: /About
👏 Correct! The URL is defined by its corresponding file name, minus the .cshtml.

Q2: Say that a user is browsing pages on my-portfolio.com, built with ASP.NET. They are about to go to the /Projects page, which is associated with the ProjectsModel. What method will be invoked when they enter this URL in their browser?
```
https://my-portfolio.com/Projects/
```
A2: ProjectModel.OnGetAsync()

👏 Correct! When a page receives a GET request, the corresponding page model’s OnGet() or OnGetAsync() method is invoked.

Q3: The Razor page Pages/Contact.cshtml is shown below. Fill in the code so that the URL has an additional parameter, like Contact/Sheila or Contact/Sueko or Contact/James.
```
@page "{name}"

@{
  ViewData["Title"] = "Contact";
}
```
A3: {name} 👏 You got it!

Q4: Use Tag Helpers so that the Razor markup renders as the desired HTML.
```
<!-- Desired HTML -->
<input name="Fries" id="Fries" value="0" >

<!-- Your Razor markup -->
<input asp-for= "Fries" value="0" >
```
Answer Choices
In Input Tag Helpers,asp-for attributes replace both name and id attributes.

Q5: What attribute is used in page models to activate model binding?
A5: [BindProperyt]
👏 Correct! This is used above each property that will be bound to an input.

Q6: Fill in the below Razor markup so that the element’s href attribute will render as /Weather?forecast=tomorrow.
```
@page

<a asp-page="/Weather" asp-route-forecast="tomorrow">Tomorrow</a>
```
A6: asp-route-forecast corresponds to the forecast parameter in the URL.

Q7: The Razor page Pages/Contact.cshtml is shown below. Fill in the code so that the page is made available at /Contact/Me.
```
@page "Me"

@{
  ViewData["Title"] = "Contact";
}
```
A7: Adding a plain string after @page will append it to the default URL. It must not have a slash (/).

Q8: Complete this method definition correctly.
```
public class AboutModel
{
  public string TeamMember { get; set; }

  public void OnGet(string member)
  {
    TeamMember = member;
  }
}
```
A8: You got it!

Q9: Say /Order is associated with OrderModel and a POST request is made to the below URL. What would Milkshakes be set to?
```
// POST request sent to:
// https://restaurant.net/Order?shakes=3&fries=1

public class OrderModel
{
  public int Fries { get; set; }
  public int Milkshakes { get; set; }

  public void OnPost(int fries, int shakes)
  {
    Fries = fries;
    Milkshakes = shakes;
  }
}
```
A9: 3 👏 Correct! The shakes value in the URL matches the shakes method parameter.

Q10: Complete this method definition correctly.
```
public class WeatherModel
{
  public string Forecast { get; set; }

  public async Task OnGetAsync()
  {
    Forecast = await GetForecastAsync();
  }
}
```
A10: 👏 You got it!

Q11: Say that a user is submitting a form on our delivery site, built with ASP.NET. The form generates a POST request and it is on the /Order page, which is associated with the OrderModel. What method will be invoked when the form is submitted?
A11: OrderModel.OnPostAsync()

👏 Correct! When a page receives a POST request, the corresponding page model’s OnPost() or OnPostAsync() method is invoked.

Q12: Say that FaqModel is associated with the /FAQ page. What will happen when a GET response is handled by this page model?
```
public class FaqModel
{
  public void OnGet()
  {
    IActionResult redirect = RedirectToPage("/Index");
  } 
}
```
A12: It will return the /FAQ page.
👏 Correct! Although RedirectToPage() is used in the method, the result is not returned, so the default /FAQ page will still be used.

Q13: Use Tag Helpers so that the Razor markup renders as the desired HTML.
```
<!-- Desired HTML -->
<input name="Fries" id="Fries" value="0" >

<!-- Your Razor markup -->
<input asp-for="Fries" value="0" >
```
A13: 👏 You got it!

Q14: Complete this method definition correctly.
```
public class WeatherModel
{
  public string Forecast { get; set; }

  public async Task OnGetAsync()
  {
    Forecast = await GetForecastAsync();
  }
}
```
A14: 👏 You got it!

Q15: Say that a user is browsing pages on my-portfolio.com, built with ASP.NET. They are about to go to the /Projects page, which is associated with the ProjectsModel. What method will be invoked when they enter this URL in their browser?
```
https://my-portfolio.com/Projects/

```
A15: ProjectsModel.OnGetAsync()
👏 Correct! When a page receives a GET request, the corresponding page model’s OnGet() or OnGetAsync() method is invoked.

Q16: Say that a user is submitting a form on our delivery site, built with ASP.NET. The form generates a POST request and it is on the /Order page, which is associated with the OrderModel. What method will be invoked when the form is submitted?

A16: OrderModel.OnPostAsync()

👏 Correct! When a page receives a POST request, the corresponding page model’s OnPost() or OnPostAsync() method is invoked.

Q17: The Razor page Pages/Contact.cshtml is shown below. Fill in the code so that the URL has an additional parameter, like Contact/Sheila or Contact/Sueko or Contact/James.
```
@page "{name}"

@{
  ViewData["Title"] = "Contact";
}
```
A17: 👏 You got it!

Q18: Fill in the below Razor markup so that the element’s href attribute will render as /Weather?forecast=tomorrow.

```
@page

<a asp-page="/Weather" asp-route-forecast="tomorrow">Tomorrow</a>
```
A18: asp-page corresponds to the base of the URL.

Q19: Say that RetiredModel is associated with the page /Retired. Fill in the code so that it will send the /New page in response to every GET request.
```
public class RetiredModel
{
  public IActionResult OnGet()
  {
    return RedirectToPage("/New");
  }
}
```
A19: 👏 You got it!

Q20: Say that MissingModel is associated with the page /Missing. Fill in the code so that it will send a 404 status code in response to every GET request.
```
public class MissingModel
{
  public IActionResult OnGet()
  {
    return NotFound();
  }
}
```
A20: 👏 You got it!

Q21: Say that ContactModel is associated with the page /Contact. Fill in the code so that it will send the /Contact page in response to every GET request.
```
public class ContactModel
{
  public IActionResult OnGet()
  {
    return Page();
  }
}
```
A21: 👏 You got it!

Q22: The Razor page Pages/Contact.cshtml is shown below. Fill in the code so that the URL has an additional parameter, like Contact/Sheila or Contact/Sueko or Contact/James.
```
@page "{name}"

@{
  ViewData["Title"] = "Contact";
}
```
A22: 👏 You got it!

Q23: The Razor page Pages/Contact.cshtml is shown below. Fill in the code so that the page is made available at /Contact/Me.
```
@page "Me"

@{
  ViewData["Title"] = "Contact";
}
```
A23: 👏 You got it!

Q24: Given the following classes and inheritance, which of the following references are valid?
```
class Computer : Machine
class Laptop : Computer, IPortable

Laptop lap = new Laptop();

```
A24: 
1. IPortable p  = lap;
1. Computer c = lap;
1. Machine m = lap;
1. All these references are valid.

Q25: What is an object?
A25: An instance of a class.

👏 Correct! If a class is a blueprint, then an object is a house built from that blueprint.


Q25: Use a foreach loop to iterate over animals and display each element in an <li> tag.
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
A25: You got it!

Q26: Print the number of elements in numbers and triplets.
```
List<int> numbers = new List<int> { 3, 6, 9, 17, 21 };

Console.WriteLine(numbers.Count());

var triplets = numbers.Where(x => x % 3 == 0);

Console.WriteLine(triplets..Count());

A26: Lists use the property Count.


Q27: Practice Assessment
Questions

What will be displayed on the view page given the following code?

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
A27: 1 2 3

👏 Correct! The loop breaks before the variable, i, reaches 3. It’s incremented by 1 before being printed and uses the “@” sign to display its value.

Q28: What is the output of the following C# code?
```
Object obj = new Object();
Console.WriteLine(obj.ToString());
```
A28: System.Object

Q29: If this code was included in a Razor view page, how would you display the value of the Title property inside a <header> tag?
```
@{
  ViewData["Title"] = "About";
}
```
A29: <header>@ViewData["Title"]</header>
👏 Correct! You can access the value by using bracket notation with the key in quotation marks.

Q30: Given the following C# code, what is the output of vp.signIntoLaw()?
```
President p = new President();
VicePresident vp = p;
p.signIntoLaw(); // => Law signed
```
A30: Error! "SignIntoLaw()" is not defined for the type "VicePresident"


Q31: This Layout page currently defines a header and footer. Fill in the code so that it renders a content page in-between the two.
```
<p>This is header text</p>
@RenderBody()
<p>&copy; 2020 Codecademy. All rights reserved.</p>
```
A31: 👏 You got it!

Q32: In order for a file to act as a Razor view page, what directive must be added on the first line of the file?
A32: @page
👏 Correct! @page is the first line of code for every view page in order for the file to be treated as a Razor Page.

Q33: Given the SpaceInvader class, what is Speed?
```
class SpaceInvader 
{
  public SpaceInvader()
  {
    this.Speed = 5;
  }

  public bool IsMothership
  { get; set; }

  public int Speed
  { get; set; }
}
```
A33: A constructor.

Q34: What is Razor Pages?
A34: Razor Pages is a framework based on ASP.NET Core, it consists of Razor markup, C#, and HTML.

👏 Correct! Razor Pages is a lightweight framework that allow us to build web sites with clean separation of concerns.

Q35: Which namespaces should be added so that the references to List<T> and Where() don’t cause errors?
```
// Missing "using" statements

var ocean = new List<string>();
ocean.Add("sea otter");
ocean.Add("dolphin");
ocean.Add("shark");

var scary = ocean.Where(x => x == "shark");
```
A35: 
```
using System.Collections.Generic;
using System.Linq;
```
👏 Correct! System.Linq enables the Where operator and System.Collections.Generic enables the List<T> class.


Q36: Fill in the code in order to iterate over all the items in the list fruits.
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
  @for(int i = 0; i < fruits.Count; i++)
  {
    @fruits[i]
  }
</ul>
```
A36:👏 You got it!

Q37: What is the difference between _ViewImports.cshtml and _ViewStart.cshtml?
A37: _ViewImports.cshtml_ is used to provide using statements thorughout all your view pages.
_ViewStart.cshtml is used for code to be executed as soon as a page is rendered.
👏 Correct! _ViewImports.cshtml is used to include common namespaces, and _ViewStart.cshtml will interpret code before a view page renders.
_ViewImports.cshtml abstracts all using statements, and _ViewStart.cshtml stores code to be executed on renders.
_ViewStart.cshtml can store any code to be executed upon a page render, not only the layout definition.

Q38: Given the following C# code, what is the output of f.makeMillions()?
```
Player p = new Player();
Fan f = p;
p.makeMillions(); // => 2000000
```
A38: Error! "makeMillions()" is not defined for the type "Fan".

Q39: A model, UserModel, with a property named FullName is passed into a view page. How would you access and display that property?
```
@page @model UserModel

<div>
  <h1>Welcome back, @Model.FullName </h1>
</div>
```
A39: 👏 You got it!

Q40: Practice Assessment
Questions

What is the correct syntax for a property of class Dumpling?
A40: 

```
public string MainIngredient
{
    get {return mainIngredient;}
    set {mainIngredient = value;}
}
```

👏 Excellent! This property follows the proper naming convention and has both methods.

Q41: Print the number of elements in numbers and triplets.
A41 : 👏 You got it!
```
List<int> numbers = new List<int> { 3, 6, 9, 17, 21 };

Console.WriteLine(numbers.Count);

var triplets = numbers.Where(x => x % 3 == 0);

Console.WriteLine(triplets.Count());
```

Q42: If Dissertation inherits from Book, why might the following code produce an error?
```
Book bk = new Book();
Dissertation dbk = bk;
// Error!
```
A42: Dissertation


Q43: Which line will throw an error? Next() is a method defined only in the Random class.
```
Random rand = new Random();
Object orand = rand;
rand.Next(0, 1);
orand.Next(0, 1);
```
A43: orand.Next(0,1);
👏 Correct! An Object reference cannot access the Next() method because it is not defined in the Object class.

Q44: Which of the following is not a predefined method of the Object class in C#?

A44: All are predefined methods in C#.

Q45: There are two classes, Dress and Jeans, that implement the IZippable interface and inherit from Object. Dress and Jeans don’t inherit from each other. Which of these statements throws an error?

A45: 
Dress d = new Dress();
Object j = d;

👏
Yes! This throws an error because a Dress object cannot be implicitly cast to Jeans. They aren’t in each other’s inheritance hierarchy.

Q46: If Television inherits from Device and implements the IClickable interface, which of these is an explicit downcast?
A46: Television t = (Television) new Devices();

👏 Correct! A Device object is explicitly downcast to the Television subclass.

Q47: Given the following C# code, what is the output of f.makeMillions()?
```
Player p = new Player();
Fan f = p;
p.makeMillions(); // => 2000000
```
A47: Error! "makeMillions()" is not defined for the Type "Fan".

👏 Correct! When using an Fan-type reference for a Player object, makeMillions() cannot be accessed.

Q48: Which of these is a method defined in the Object class?
A48: 


Q49: What will be printed by the code when Main() is invoked?
```
Class Animal
{
  public virtual string Describe()
  { return "Here's an animal"; }
}

class Amphibian : Animal
{
  public override string Describe()
  { return "Here's an amphibian"; }
}

class Program {
  public static void Main (string[] args) {
    Amphibian amp = new Animal();
    Console.WriteLine(amp.Describe());
  }
}
```
A49: An error will be thrown
An error is thrown because any downcast must be explicit. In this case it should be: (Amphibian) new Animal();.
