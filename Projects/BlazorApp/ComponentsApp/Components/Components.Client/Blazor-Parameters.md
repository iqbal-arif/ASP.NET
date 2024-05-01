**Parameters**
***

1. Define page as Razor Component BetterCounter

2. Define interactivity attribute
@rendermode InteractiveAuto

3. Define Prop instead of Field as Title will be read from different location. So private field will not work. So in stead use prop to define variable as such, see below
    public string? Title { get; set; }
	
***Note: [Parameter] helps in passing values as paramter***

5. The nullable Title? helps pass parameter to the link
	@page "/BetterCounter/{Title?}"
	a. pass https://localhost:7093/BetterCounter/BetterCounter
	will show on the page as BetterCounter
	b. pass https://localhost:7093/BetterCounter/Title%20Counter
	will show on the page as Title Counter
	 
	
4.Defining protected override method
protected override void OnParametersSet(), Does 2 things
	a. Allows to display/override any title with page link
	https://localhost:7093/Bettercounter/; show "Our Better Counter" title, and
	b. pass https://localhost:7093/BetterCounter/Title%20Counter
	will show on the page as "Title Counter"
	@attribute [Route(nameof(Start))]
***Note: the nameof(Start) is a reference to the page. So it will know if the page is renamed. But it would not @page method.***
3. Define Naviation Dependency Injection
@inject NavigationManager for Navigating to specific page.
***Note: Navigation.NavigateTo("counter"); is an enhanced Navigation. Meaning it won't refresh Full Page Refresh when using NavigatToPage to navigate from page to page. Uncomment the navigation in Layout/NavMenue.razor file.***
4. Define Method and button with event handler to display on the page.
5. Define page as a full page in Home.razor
