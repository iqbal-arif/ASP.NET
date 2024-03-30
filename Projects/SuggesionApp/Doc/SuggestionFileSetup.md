**BLAZOR - SuggestionAppUI**
***
1. GlobalUsing : Setting GlobalUsings.cs to reference SuggestionAppLibrary for SuggestionAppUI and works independent of the Library but access the SuggetionAppLibray/DataAccess
2. Dependency Injection : Set ConfigureServices() (or any other name as ConfigureInjection()) and move dependency injection from Program.cs to RegisterService.cs.  This is done to keep code clean and set separate class to reduce program.cs services.
3. Memory Caching : in RegisterServices add AddMemoryCache()
   







**AppLibrary - SuggestionAppLibrary**
***

1. MODELS / SuggestionModel.cs
2. DATA / DbConnection.cs  : Connection for MongoDb
3. GlobalUsing : Setting for AppLibrary to reference Models and DataAcces. And it creates DLL for Blazor
4. Memory Caching : Already added memory package in the SuggesitonAppLibrary
 <PackageReference Include="Microsoft.Extensions.Caching.Memory" Version="6.0.0" />

5. Data Design to Library
	a. CategoryModel : properties and MongoDb Unique Identifier setup
	b. StatusModel :   properties and MongoDb Unique Identifier setup
	c. SuggestionModel:properties and MongoDb Unique Identifier setup, 
					   HasSet<strring> stores only unique values to avoid Duplicates
					   StatusModel : Suggestion Completed, Watched, Upcoming
					   OwnerNotes :  More description for a Suggestion
	d. UserModel:	   properties and MongoDb Unique Identifier setup, Azuer ID (For user Identity)
					   (SubObject) BasicSuggestionModel for Id & Suggestion Title (Extracted from SuggestionModel)
					   (SubObect) BasicUserModel :properties and MongoDb Unique Identifier setup 
6. DataAccess
	1. Creates a Singleton out of the independence Injection while keeping the conneciton open continously
	2. Change Singleton to Scoped Class where Independence Injection for every User gets a Singleton version 
	3. Lesson 9 : Database connection class DbConneciton.cs



**DataBase Connection Settings**
***
1. appsettings.json
	a. "DatabaseName": "devsuggestionapp" : The name can be different for different enviornment like production database should be named differently.
2. secrets.json (RightClick on SuggesitonAppUI/Manage User Secrets) : Contains server connection string store seperately. Don't commit to git or any online userControl. In production it is placed in CI/CD process.



	