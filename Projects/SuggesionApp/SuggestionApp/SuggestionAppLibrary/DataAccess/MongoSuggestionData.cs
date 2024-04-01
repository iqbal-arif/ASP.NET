
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
}
