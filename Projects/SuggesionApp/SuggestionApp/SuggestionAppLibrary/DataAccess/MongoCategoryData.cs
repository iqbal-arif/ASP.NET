

using Microsoft.Extensions.Caching.Memory;

namespace SuggestionAppLibrary.DataAccess;

public class MongoCategoryData : ICategoryData
{
   private readonly IMongoCollection<CategoryModel> _categories;
   private readonly IMemoryCache _cache;
   private const string cacheName = "CategoryData";

   public MongoCategoryData(IDbConnection db, IMemoryCache cache)
   {
      _cache = cache;

      _categories = db.CategoryColleciton;
   }
   //List that will be displayed on the page. So caching it once a day and processing data from it.

   public async Task<List<CategoryModel>> GetAllCategories()
   {
      var output = _cache.Get<List<CategoryModel>>(cacheName);

      if (output == null)
      {
         var resutls = await _categories.FindAsync(_ => true);

         output = resutls.ToList();

         _cache.Set(cacheName, output, TimeSpan.FromDays(1));
      }

      return output;
   }

   // Creating the Category

   public Task CreateCategory(CategoryModel category)
   {
      return _categories.InsertOneAsync(category);
   }
}
