

using MongoDB.Driver;

namespace SuggestionAppLibrary.DataAccess;

public class MongoUserData
{
   private readonly IMongoCollection<UserModel> _users;

   //Collecting UserCollection already Instantiated by IMongoDb and assigning it to _users
   //Copying the refernce of t
   public MongoUserData(IDbConnection db)
   {
      _users = db.UserCollection;
   }
   //Get all users Model Asynchronously
   public async Task<List<UserModel>> GetUsersAsync()
   {
      var results = await _users.FindAsync(_ => true);
      return results.ToList();
   } 
   
   //Get a singal user  Asynchronously
   public async Task<UserModel> GetUser(string id)
   {
      var results = await _users.FindAsync(u => u.Id == id);
      return results.FirstOrDefault();
      
   } 
   //Getting one User with Azure Id authentication
   public async Task<UserModel> GetUserFromAuthentication(string objectId)
   {
      var results = await _users.FindAsync(u => u.ObjectIdentifier == objectId);
      return results.FirstOrDefault();
   }


}
