**Tag Helpers**
***

Tag Helpers are very useful ways to create HTML elements with server-side attributes. For example, when we use an anchor tag, <a>, we usually have an href attribute to direct the user to a specific page when they click it. Razor Pages provides handy Tag Helpers that help us generate links and other useful information.

So instead of writing an anchor tag as so:
```
<a href="/Attendee?attendeeid=10">View Attendee</a>
```
We can rewrite it with a Tag Helper like this:
```
<a asp-page="/Attendee"
   asp-route-attendeeid="10">View Attendee</a>
```
The syntax allows developers to easily customize the UI using HTML/CSS knowledge.

There are many available predefined Tag Helpers to help us generate links, create forms, load assets, etc. There is even one to help us render partials which we just went over! So let’s go ahead and take a look at how some of them work.

```<partial name="_ItemPartial" ... />```

In the tag above, we’re using one of the predefined Tag Helpers provided by ASP.NET: <partial …>, the partial tag will take a required name attribute that searches all registered partial locations for the file with that name, and once the page is loaded, the server will render the HTML from that file. Certain tag helpers have optional attributes that they can take. The partial one has the following optional attributes:

   1.  for: Assigns an expression to be evaluated against the current model. This is one way to pass data to the partial.

```<partial name="_ItemPartial" for="Item" />```

Note: The model syntax is inferred so we don’t need to use ***@Model.Item***

   2.  model: The model the partial references. This is another way to pass data into our partial. The main difference between model and for, is that model allows you to use a more specific model instead of the inferred one that for provides. HOWEVER, we can’t use it in conjunction with for. We must use one or the other:

```<partial name="_ItemPartial" model="Model.Item" />```

In this case, we could pass in a brand new instance of our model:

``<partial name="_ItemPartial" 
model='new Item { Number = 1, Name: "Test Item, Price: 10"}'/>``

  3.  view-data: Assigns a key/value pair of type ViewDataDictionary that we can pass directly into the partial view:

```@{
    ViewData["IsItemReadOnly"] = true;
}

<partial name="_ItemPartial" view-data="ViewData" />```

During runtime, the Razor Application will process the markup and when it reads out certain Tag Helpers it will convert them into plain HTML before sending the page to the user. For reference, here is a list of all the tag helpers provided by ASP.NET!

***Select Tag Helper*** (https://learn.microsoft.com/en-us/aspnet/core/mvc/views/working-with-forms?view=aspnetcore-8.0#the-select-tag-helper)


**Explorella.cshtml.cs**
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
  public class ExplorellaModel : PageModel
  {
    public string Country { get; set; }
    public List<SelectListItem> Countries { get; set; }
    public void OnGet()
    {
      new SelectListItem("AR","Argentina")
      new SelectListItem("FR","France")
      new SelectListItem("BR","Brazil")
      new SelectListItem("GER","Germany")
      new SelectListItem("CHI","China")
    }
  }
}
```

**Explorella.cshtml**
```
@page
@model MyApp.Namespace.ExplorellaModel
@{
}

<div class="jumbotron jumbotron text-white" style="background-image: url(https://c1.staticflickr.com/1/725/20835879729_66b87b0759_b.jpg); background-repeat: no-repeat;
    background-position: center center;
    background-size: cover;">
	<div class="container">
		<h2 class="text-center display-3 mb-4">Welcome to Explorella!</h1>
	</div>
</div>
<h1 class="display-5">Pick your next destination!</h1>

<form class="form-inline">
  <label class="my-1 mr-2" for="inlineFormCustomSelectPref">Preference</label>
 /*/*/*/*/*/*/*/*/Exercise Starts Here/*/*/*/*/*/*/*/*/*/ 
  <!-- Select Tag Helper -->
  <select class="custom-select my-1 mr-sm-2" asp-for="Country" asp-items="Model.Countries">
  </select>
   /*/*/*/*/*/*/*/*/Exercise Ends Here/*/*/*/*/*/*/*/*/*/ 
  <div class="custom-control custom-checkbox my-1 mr-sm-2">
    <input type="checkbox" class="custom-control-input" id="customControlInline">
    <label class="custom-control-label" for="customControlInline">Remember my preference</label>
  </div>

  <button type="submit" class="btn btn-primary my-1">Submit</button>
</form>
```