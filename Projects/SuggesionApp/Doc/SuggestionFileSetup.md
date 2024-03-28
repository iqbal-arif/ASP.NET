BLAZOR - SuggestionAppUI
1. GlobalUsing : Setting GlobalUsings.cs to reference SuggestionAppLibrary for SuggestionAppUI and works independent of the Library but access the SuggetionAppLibray/DataAccess
2. Dependency Injection : Set ConfigureServices() (or any other name as ConfigureInjection()) and move dependency injection from Program.cs to RegisterService.cs.  This is done to keep code clean and set separate class to reduce program.cs services.
   







AppLibrary - SuggestionAppLibrary

1. MODELS / SuggestionModel.cs
2. DATA / DbConnection.cs  : Connection for MongoDb
3. GlobalUsing : Setting for AppLibrary to reference Models and DataAcces. And it creates DLL for Blazor
