ASP.NET CORE MVC

1. Models : 
	1. Containes C# Classes with Properties
	2. Represent Table in database
	3. Properties are the coloumns of the Tables


2. Connection String :
	1. Links from C# code to physical Database.
	2. Conatians the Address where database is located.
	3. Authenticate teh database services.
	4. Connection strings are stored in AppSettings.JSON file

3. Context :

	1. A Class acts as middleman
	2. Contains Methods to call Database to do actions like, add a record or return all rows in tables.
	3. Methods are used to handel User requests through context file Controller.
	4. Context relies on Connection string in AppSettings.JSON to locate Database file.
	5. Make changes to Database Tables by connecting the Models with Database.
	
4. Database:

	1. Stores the Tables containing all teh data of the App.

4. View Pages :
	
	1. Contains all the FrontEnd side of the Application.
	2. Renders pages in the Browser.
	3. Interact with Context to paste the data from Database into the pages and renders to Browser. 
		


Installation
1. Package Manger : Project => Mange NuGet Packages
	a. Install MS.EntityFrameworkCore
	b. Install MS.EntityFrameworkCore.Tools
	c. MS.EntityFrameworkCore.SqlServer