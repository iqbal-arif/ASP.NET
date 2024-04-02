
using Microsoft.Extensions.Caching.Memory;

namespace SuggestionAppLibrary.DataAccess;

public class MongoSuggestionData : ISuggestionData
{
   private readonly IDbConnection _db;
   private readonly IUserData _userData;
   private readonly IMemoryCache _cache;
   private readonly IMongoCollection<SuggestionModel> _suggestions;
   private const string CacheName = "SuggestionData";

   //CONSTRUCTOR
   public MongoSuggestionData(IDbConnection db, IUserData userData, IMemoryCache cache)
   {
      _db = db;
      _userData = userData;
      _cache = cache;
      _suggestions = db.SuggestionColleciton
   }

   //GET ALL SUGGESTIONS
   public async Task<List<SuggestionModel>> GetAllSuggestions()
   {
      var output = _cache.Get<List<SuggestionModel>>(CacheName);

      if (output == null)
      {
         var resutls = await _suggestions.FindAsync(s => s.Archived == false);
         output = resutls.ToList();

         _cache.Set(CacheName, output, TimeSpan.FromMinutes(1));
      }

      return output;

   }

   //GET ALL APPROVED SUGGESTIONS
   public async Task<List<SuggestionModel>> GetAllApprovedSuggestions()
   {

      var output = await GetAllSuggestions();
      return output.Where(x => x.ApprovedForRelease).ToList();

   }

   //GET ONE SPECIFIC SUGGESTION
   public async Task<SuggestionModel> GetSuggestion(string id)
   {
      var results = await _suggestions.FindAsync(s => s.Id == id);
      return results.FirstOrDefault();
   }

   //GET ALL SUGGESTION WATING APPROVAL
   public async Task<List<SuggestionModel>> GetAllSuggestionsWaitingForApproval()
   {
      var output = await GetAllSuggestions();

      return output.Where(x => x.ApprovedForRelease == false && x.Rejected == false).ToList();
   }

   //UPDATE SUGGESTION
   public async Task UpdateSuggestion(SuggestionModel suggestion)
   {
      await _suggestions.ReplaceOneAsync(s => s.Id == suggestion.Id, suggestion);
      _cache.Remove(CacheName);

   }

   //UPDATE VOTE ON SUGGESTION
   public async Task UpvoteSuggestion(string suggestionId, string userId)
   {
      var client = _db.Client;

      using var session = await client.StartSessionAsync();

      session.StartTransaction();

      try
      {
         var db = client.GetDatabase(_db.DbName);

         var suggestionInTransaction = db.GetCollection<SuggestionModel>(_db.SuggestionCollectionName);

         var suggestion = (await suggestionInTransaction.FindAsync(s => s.Id == suggestionId)).First();

         bool isUpvote = suggestion.UserVotes.Add(userId);
         if (isUpvote == false)
         {
            suggestion.UserVotes.Remove(userId);
         }

         await suggestionInTransaction.ReplaceOneAsync(s => s.Id == suggestionId, suggestion);

         var usersInTransaction = db.GetCollection<UserModel>(_db.UserCollectionName);

         var user = await _userData.GetUser(suggestion.Author.Id);

         if (isUpvote)
         {
            user.VotedOnSuggestions.Add(new BasicSuggestionModel(suggestion));
         }
         else
         {
            var suggestionToRemove = user.VotedOnSuggestions.Where(s => s.Id == suggestionId).First();
            user.VotedOnSuggestions.Remove(suggestionToRemove);
         }

         await usersInTransaction.ReplaceOneAsync(u => u.Id == user.Id, user);

         await session.CommitTransactionAsync();

         _cache.Remove(CacheName);

      }
      catch (Exception ex)
      {
         await session.AbortTransactionAsync();
         throw;
      }
   }

   //CREATE A SUGGESTION

   public async Task CreateSuggestion(SuggestionModel suggestion)
   {
      var client = _db.Client;

      using var session = await client.StartSessionAsync();

      session.StartTransaction();

      try
      {
         var db = client.GetDatabase(_db.DbName);

         var suggestionInTransaction = db.GetCollection<SuggestionModel>(_db.SuggestionCollectionName);

         await suggestionInTransaction.InsertOneAsync(suggestion);

         var usersInTransaction = db.GetCollection<UserModel>(_db.UserCollectionName);
         var user = await _userData.GetUser(suggestion.Author.Id);
         user.AuthoredSuggestions.Add(new BasicSuggestionModel(suggestion));
         await usersInTransaction.ReplaceOneAsync(u->u.Id == user.Id, user);

         await session.CommitTransactionAsync();

      }
      catch (Exception ex)
      {
         await session.AbortTransactionAsync();
         throw;
      }

   }
}