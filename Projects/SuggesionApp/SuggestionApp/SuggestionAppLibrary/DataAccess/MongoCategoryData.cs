

using Microsoft.Extensions.Caching.Memory;

namespace SuggestionAppLibrary.DataAccess;

public class MongoCategoryData
{
   private readonly IMongoCollection<CategoryModel> _categories;
   private readonly IMemoryCache _cache;

   public MongoCategoryData(IDbConnection db, IMemoryCache cache)
   {
      _cache = cache;

      _categories = db.CategoryColleciton;
   }


}
