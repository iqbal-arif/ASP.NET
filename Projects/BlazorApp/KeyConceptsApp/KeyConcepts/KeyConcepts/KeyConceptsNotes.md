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
10. Injecting Iconfiguration in Home.razor
	a. @inject IConfiguration config
<h2>@config.GetConnectionString("Default")</h2>
	b. The IConfigurartion helps reading appsettings.json value in page. See below.

***Video-40: ++Dependency_Injection vs. Property Injection++***_	
**appsettings.json**
***
1.Adding value in appsettings.json file 
"ConnectionStrings": {
    "Default": "This is the connection string from appsettingsjson"
  }
2.Adding value in appsettings.Development.json file 
"ConnectionStrings": {
    "Default": "This is the connection string from appsettings.Development.json"
  }
3.Adding value in KeyConcepts Secrets.json file
"ConnectionStrings": {
    "Default": "This is the connection string from appsettings.Development.json"
  }
4.Values are depends on the hiearchy of file. appsettings.json => appsettings.Development.json => sercrets.json. Highest priorty is given to secrects.json

**Adding Key-pair vales and reading as string in Client Page**
***

1. Add the value in appsettings.json
1. "WorkDaysPerWeek" :  5
1. In Home.razor get value
<h3>Workday : @(config.GetValue<string>("WorkDaysPerWeek"))</h3> 
**KeyConcepts.Client**
***
1.KeyConcepts.Client; Referencind Dependencise:
	a. Right-Click on KeyConcepts Server Dependencies - Add Project Reference; Select DependencyLibrary
_	b. In Demo.razor: Define full page
		@page "/demo"
	c. Inject the DemoDependency in Demo.razor page
	@inject DemoDependency demo
	d. Define using in _imports.razor to reference DemoDependency.	@using DependencyLibrary in KeyConcepts.Client app


**Head_Components**
***
1. <HeadOutlet /> in App.razor renders all meta data per page in <HeadContent>.
1. Add the following item for different page in <HeadContent>. see below
1. <HeadContent>
    <meta name="description" content="This is the description for the home page"/>
</HeadContent>