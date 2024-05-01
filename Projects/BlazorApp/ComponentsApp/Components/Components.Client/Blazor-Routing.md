**Definning Page Route**
***

1. Define page as Razor Component

2. Define interactivity attribute
@rendermode InteractiveAuto
**
3. Routing Through @page attribute
	a. @page "/page"
	b. @page "/pages/page"
	c. @page "/color"
	d. @page "/colour"
***Note: Remember to give the same name to page as the file name.***
4. Routing Through Routing attribute
	@attribute [Route(nameof(Start))]
***Note: the nameof(Start) is a reference to the page. So it will know if the page is renamed. But it would not @page method.***
5. Routing Through











1. 
3. Define Naviation Dependency Injection
@inject NavigationManager for Navigating to specific page.
***Note: Navigation.NavigateTo("counter"); is an enhanced Navigation. Meaning it won't refresh Full Page Refresh when using NavigatToPage to navigate from page to page. Uncomment the navigation in Layout/NavMenue.razor file.***
4. Define Method and button with event handler to display on the page.
5. Define page as a full page in Home.razor

