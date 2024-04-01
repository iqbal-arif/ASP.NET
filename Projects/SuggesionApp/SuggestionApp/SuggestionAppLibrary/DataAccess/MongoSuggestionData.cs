
using Microsoft.Extensions.Caching.Memory;

namespace SuggestionAppLibrary.DataAccess;

public class MongoSuggestionData
{
   private readonly IDbConnection _db;
   private readonly IUserData _userData;
   private readonly IMemoryCache _cache;
   private readonly IMongoCollection<SuggestionModel> _suggestions;
   private const string CacheName = "SuggestionData";


   public MongoSuggestionData(IDbConnection db, IUserData userData, IMemoryCache cache)
   {
      _db = db;
      _userData = userData;
      _cache = cache;
      _suggestions = db.SuggestionColleciton
   }

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

   public async Task<List<SuggestionModel>> GetAllApprovedSuggestions()
   {

      var output = await GetAllSuggestions();
      return output.Where(x => x.ApprovedForRelease).ToList();

   }
   
   //One Suggestion
   public async Task<SuggestionModel> GetSuggestion(string id)
   {
      var results = await _suggestions.FindAsync(s => s.Id == id);
      return results.FirstOrDefault();
   }

   public async Task<List<SuggestionModel>> GetAllSuggestionsWaitingForApproval()
   {
      var output = await GetAllSuggestions();

      return output.Where(x => x.ApprovedForRelease == false && x.Rejected == false).ToList();
   }


   public async Task UpdateSuggestion(SuggestionAppLibrary suggestion)
   {
      await _suggestions.ReplaceOneAsync(s => s.Id == suggestion.Id, suggestion);
      _cache.Remove(CacheName);

   }

   public async Task UpvoteSuggestion( string suggestionId , string userId)
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
         if 
      }
      catch (Exception ex)
      {  
         await session.AbortTransactionAsync();
         throw;
      }
   }
}