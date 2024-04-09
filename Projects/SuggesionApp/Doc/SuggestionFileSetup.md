**File Setup**
***
Lesson 6: ***1. Blazor Server App BoilerPlate Setup*** 
		  2. Class Library .NET Standard or .NET Core : SuggestionAppLibrary
		  3. Right-Click on SuggestinAppUI (Set a Startup Project)
		  4. Right-Click on SuggestionApp / (Add a EditConfig file) : .editodrconfig  (To style the current solution file)
		  5. Remove FetchData.razor Counter.razor Shared/SurvyPrompt.razor
		  6. Remove in index.razor page <SurveyPrompt...../>
		  7. In Program.cs remove. builder.Services.....<WeatherForecastService>()
		  8. Remove Data folder and all its content (WeatherForecast.cs ; WeatherForecasetService.cs)
		  9. Remove NavMenu.razor
		  10. Remvoe using SuggestionAppUI.Data; in Program.cs
		  11. In MainLayout.razor remove <NavMenue section.
		  12. Remove Aout Section in MainLayout.razor
		  13. Remove class="tkop-row px-4"





**BLAZOR - SuggestionAppUI**
***

Added following files and folders
1. Components
2. Models
3. wwwroot/images


1. GlobalUsing : Setting GlobalUsings.cs to reference SuggestionAppLibrary for SuggestionAppUI and works independent of the Library but access the SuggetionAppLibray/DataAccess
2. Dependency Injection : Set ConfigureServices() (or any other name as ConfigureInjection()) and move dependency injection from Program.cs to RegisterService.cs.  This is done to keep code clean and set separate class to reduce program.cs services.
3. Memory Caching : in RegisterServices add AddMemoryCache()
4. Blazer Page: Pages/Add Razor Component
   







**AppLibrary - SuggestionAppLibrary**
***

1. MODELS / SuggestionModel.cs (Specific to DataAcess)
2. DATA / DbConnection.cs  : Connection for MongoDb (Get info in and out Of Db)
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
	4. MongoUserData L10 : UserModel Methods
	5. MongoStatusData L10
	6. MongoSuggestionData L11 : Create a Suggetion Method. Added Dependency Injections in SuggestionAppUI/RegisterServcie.cs



**DataBase Connection Settings**
***
1. appsettings.json
	a. "DatabaseName": "devsuggestionapp" : The name can be different for different enviornment like production database should be named differently.
2. secrets.json (RightClick on SuggesitonAppUI/Manage User Secrets) : Contains server connection string store seperately. Don't commit to git or any online userControl. In production it is placed in CI/CD process.



	