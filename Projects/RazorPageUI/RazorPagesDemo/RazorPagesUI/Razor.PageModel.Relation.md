_Layout.cshtml : Pages\Shared\ (This is the Main Page). All pages are rendered thorough _Layout
	@RenderBody(): This is where all Razor Pages are injected for display
	
	Example: Index.cshtml : \Pages\Index.cshtml
			@page: Razor Page
			@ means a razor syntax also used in MVC model
			@model means the data associated with the page
			@{} takes bunch of codes and display it on the webpage
			@{ViewData[""]=""} is a Dictionary stores the key-pair values. And the values are displayed or pulled in the _Layout.cshtml file.



Intro Pages:

1. Index.cshtml
	1.1. Index.cshtml.cs is a page model
			1. As logger constructor (See Loggin .Net Core tim corey video)
			2. Has two methods
				2.1. OnGet(): renders the index page
				2.2. OnPost(): post data for the index page
	1.2. Don't pass values in the above two methods. But uses properties.
		 And properties can be read by index page


2. Error.cshtml
3. Privacy.cshtml

Razor Page Layout
Adding an Add Address Page to Razor Pages that uses Razor _ViewStart.cshtml
1. Pages/Forms(Right-Click Add Razor Page)
	1. AddAddress.cshtml.cs is a View Model (That's a code behind View Page) that requires a Model (Class Object) that would be AddressModel.cs
	1.1. Bulding Form:
		1. AddAddress.cshtml.cs: Addressing propety of AddressModel property public AddressModel Address { get; set; }
		2. asp-for="Address.StreetAddress": pointing to property from Address(View Model) to Model properties, such as, StreetAddress, city, zipcode,etc.
	2. AddAddress.cshtml is a View Page the front page for user to enter input values.
2. RazorPagesUI/Models/AddressModel.cs (Right-Click on RazorPageUI Add a Class AddressModel.cs)

