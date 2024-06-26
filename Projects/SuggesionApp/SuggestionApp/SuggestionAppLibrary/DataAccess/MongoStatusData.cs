﻿

using Amazon.Runtime.Internal.Util;
using Microsoft.Extensions.Caching.Memory;

namespace SuggestionAppLibrary.DataAccess;

public class MongoStatusData : IStatusData
{
   private readonly IMongoCollection<StatusModel> _statuses;
   private readonly IMemoryCache _cache;

   private const string CacheName = "StatusData";

   public MongoStatusData(IDbConnection db, IMemoryCache cache)
   {
      _cache = cache;

      _statuses = db.StatusColleciton;
   }


   public async Task<List<StatusModel>> GetAllStatuses()
   {
      var output = _cache.Get<List<StatusModel>>(CacheName);

      if (output == null)
      {
         var resutls = await _statuses.FindAsync(_ => true);
         output = resutls.ToList();

         _cache.Set(CacheName, output, TimeSpan.FromDays(1));
      }

      return output;

   }

   // Creating the Status

   public Task CreateStatus(StatusModel status)
   {
      return _statuses.InsertOneAsync(status);
   }

}
