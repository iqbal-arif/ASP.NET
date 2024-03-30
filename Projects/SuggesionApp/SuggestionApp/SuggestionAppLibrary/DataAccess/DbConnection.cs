

using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace SuggestionAppLibrary.DataAccess;

public class DbConnection
{
   //CONSTRUCTOR FOR CONFIGURATION

   
      private readonly IConfiguration _config;

      //Database connection to MongoDb
      private readonly IMongoDatabase _db;

      //Reference to appsettings.json 
      private string _connectionId = "MongoDB";

   public string DbName { get; private set; }


   //Table Names in Database with hardcode reference : Holds Objects not row of Data
   //The reference can be changed over here if need be. private protects the accidental name change.
   public string CategoryCollectionName { get; private set; } = "categories";

   public string StatusCollectionName { get; private set; } = "statuses";

   public string UserCollectionName { get; private set; } = "users";
   
   public string SuggestionCollectionName { get; private set; } = "suggestions";


   //Client connects to Database
   public MongoClient Client { get; private set; }

   public IMongoCollection<CategoryModel> CategoryColleciton { get; private set; }

   public IMongoCollection<StatusModel> StatusColleciton { get; private set; }

   public IMongoCollection<SuggestionModel> SuggestionColleciton { get; private set; }

   public IMongoCollection<UserModel> UserCollection { get; private set; }


   //CONSTRUCTOR FOR new Client with connection to Database and creates connections to all four collections
   public DbConnection(IConfiguration config)
      {
         _config = config;

         Client = new MongoClient(_config.GetConnectionString(_connectionId));

         DbName = _config[key: "DatabaseName"]; //reference to appsettings.json

         _db = Client.GetDatabase(DbName);

         CategoryColleciton = _db.GetCollection<CategoryModel>(CategoryCollectionName);
         StatusColleciton = _db.GetCollection<StatusModel>(StatusCollectionName);
         UserCollection = _db.GetCollection<UserModel>(UserCollectionName);
         SuggestionColleciton = _db.GetCollection<SuggestionModel>(SuggestionCollectionName);

      }

  

}