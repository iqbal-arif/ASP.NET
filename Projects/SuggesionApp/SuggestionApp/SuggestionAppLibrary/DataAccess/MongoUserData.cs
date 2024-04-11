//LESSON 10

using MongoDB.Driver;

namespace SuggestionAppLibrary.DataAccess;

public class MongoUserData : IUserData // Can be used in Dependency Injection
{
   private readonly IMongoCollection<UserModel> _users;

   //Collecting UserCollection already Instantiated by IMongoDb and assigning it to _users
   //Copying the refernce of the usercollection
   //Using Depndency Injecdtion
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

   //Get a singal user Asynchronously by passing a user Id and comparing it with DB.
   public async Task<UserModel> GetUser(string id)
   {
      var results = await _users.FindAsync(u => u.Id == id);
      return results.FirstOrDefault();

   }
   //Getting one User with Azure Id authentication  (Oject Id given by Azure AD compare it)
   public async Task<UserModel> GetUserFromAuthentication(string objectId)
   {
      var results = await _users.FindAsync(u => u.ObjectIdentifier == objectId);
      return results.FirstOrDefault();
   }

   //Create User after checking the Entry in DataBase

   public Task CreateUser(UserModel user)
   {
      return _users.InsertOneAsync(user);
   }

   //Filter User after checking the Entry in DataBase then Updated it


   public Task UpdateUser(UserModel user)
   {
      var filter = Builders<UserModel>.Filter.Eq("Id", user.Id);
      return _users.ReplaceOneAsync(filter, user, new ReplaceOptions { IsUpsert = true });
   }


}
