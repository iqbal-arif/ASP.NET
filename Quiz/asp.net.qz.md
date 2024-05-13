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

Q6: 