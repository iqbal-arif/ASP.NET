**Parameters**
***

1. Define page as Razor Component BetterCounter

2. Define interactivity attribute
@rendermode InteractiveAuto

3. Define Prop instead of Field as Title will be read from different location. So private field will not work. So in stead use prop to define variable as such, see below
    public string? Title { get; set; }
	
***Note: [Parameter] helps in passing values as paramter***

4. The nullable Title? helps pass parameter to the link
	@page "/BetterCounter/{Title?}"
	a. pass https://localhost:7093/BetterCounter/BetterCounter
	will show on the page as BetterCounter
	b. pass https://localhost:7093/BetterCounter/Title%20Counter
	will show on the page as Title Counter

5. Passing StartingValue int as paramter
	a. Define @page route
	b. [Parameter]
       public int StartingValue { get; set; }






1. 
4. Define Method and button with event handler to display on the page.
5. Define page as a full page in Home.razor
