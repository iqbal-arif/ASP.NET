1. There are two KeyConcepts folders.
	a. KeyConcepts : SERVER SIDE
	b. KeyConcepts.Client : CLIENT SIDE
2. Pages Defined in client side can be used in Server side as long they are referenced in **_imports.razor** file
3. DependencyLibary: is defined as separate CSharp library that can be utilized by Server and Client side of App as long these are Referenced in the Dependencies.
4. Defined GiveRandomNumber method in class DemoDependency
5. Right-Click on KeyConcepts Server Dependencies - Add Project Reference; Select DependencyLibrary

6. Define using and builder method in Server App Program.cs class
	a. using DependencyLibrary 
	b. builder.Services.AddSingleton<DemoDependency>();
7. Define using in _imports.razor to reference DemoDependency.	@using DependencyLibrary
8. Inject the DemoDependency in Home.razor page
	@inject DemoDependency demo
9. The Method can be referenced to be displayed in Home Page.
	<h2>@demo.GiveRandomNumber()</h2>
10.
_

