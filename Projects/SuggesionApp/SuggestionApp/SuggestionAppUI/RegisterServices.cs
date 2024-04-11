namespace SuggestionAppUI;
//LESSON 7
public static class RegisterServices
{
   public static void ConfigureServices(this WebApplicationBuilder builder)
   {
      // Add services to the container.
      builder.Services.AddRazorPages();
      builder.Services.AddServerSideBlazor();
      //Memory Caching for Blazor
      builder.Services.AddMemoryCache();
      //Singleton for ONe Database connection for everybody use
      //All ICategoryData....IUserData rely on IDbConnection
      //REFERENCES FOR BLAZER PROJECT TO GET DATA
      builder.Services.AddSingleton<IDbConnection, DbConnection>();
      builder.Services.AddSingleton<ICategoryData, MongoCategoryData>();
      builder.Services.AddSingleton<IStatusData, MongoStatusData>();
      builder.Services.AddSingleton<ISuggestionData, MongoSuggestionData>();
      builder.Services.AddSingleton<IUserData, MongoUserData>();
   }
}
