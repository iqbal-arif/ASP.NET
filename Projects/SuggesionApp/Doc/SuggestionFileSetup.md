BLAZOR - SuggestionAppUI
1. GlobalUsing : Setting GlobalUsings.cs to reference SuggestionAppLibrary for SuggestionAppUI and works independent of the Library but access the SuggetionAppLibray/DataAccess
2. Dependency Injection : Set ConfigureServices() (or any other name as ConfigureInjection()) and move dependency injection from Program.cs to RegisterService.cs.  This is done to keep code clean and set separate class to reduce program.cs services.
3. Memory Caching : in RegisterServices add AddMemoryCache()
   







AppLibrary - SuggestionAppLibrary

1. MODELS / SuggestionModel.cs
2. DATA / DbConnection.cs  : Connection for MongoDb
3. GlobalUsing : Setting for AppLibrary to reference Models and DataAcces. And it creates DLL for Blazor
4. Memory Caching : Already added memory package in the SuggesitonAppLibrary
 <PackageReference Include="Microsoft.Extensions.Caching.Memory" Version="6.0.0" />

5. Data Design to Library
	a. CategoryModel : properties and MongoDb Unique Identifier setup
	b. StatusModel :   properties and MongoDb Unique Identifier setup
	c. SuggestionModel: 
