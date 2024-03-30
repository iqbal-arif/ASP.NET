

using MongoDB.Driver;

namespace SuggestionAppLibrary.DataAccess;

public class MongoUserData
{
   private readonly IMongoCollection<UserModel> _users;


   public MongoUserData(IDbConnection db)
   {
      _users = db.UserCollection;
   }
   //Get all users Asynchronously
   public async Task<List<UserModel>> GetUsersAsync()
   {
      var results = await _users.FindAsync(_ => true);
      return results.ToList();
   } 
   
   //Get all users Asynchronously
   public async Task<List<UserModel>> GetUser(string id)
   {
      var results = await _users.FindAsync(u => u.Id == id);
      return results.FirstOrDefault();
      
   }


}
