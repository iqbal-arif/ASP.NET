using MongoDB.Driver;

namespace SuggestionAppLibrary.DataAccess;
public interface IDbConnection
{
   IMongoCollection<CategoryModel> CategoryColleciton { get; }
   string CategoryCollectionName { get; }
   MongoClient Client { get; }
   string DbName { get; }
   IMongoCollection<StatusModel> StatusColleciton { get; }
   string StatusCollectionName { get; }
   IMongoCollection<SuggestionModel> SuggestionCollection { get; }
   string SuggestionCollectionName { get; }
   IMongoCollection<UserModel> UserCollection { get; }
   string UserCollectionName { get; }
}