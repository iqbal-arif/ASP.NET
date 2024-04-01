
namespace SuggestionAppLibrary.DataAccess;

public interface IStatusData
{
   Task CreateCategory(StatusModel status);
   Task<List<StatusModel>> GetAllStatuses();
}