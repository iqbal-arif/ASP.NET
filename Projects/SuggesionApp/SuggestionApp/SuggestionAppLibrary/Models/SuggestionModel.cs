//LESSON 8,9

namespace SuggestionAppLibrary.Models;

 public class SuggestionModel
 {
   //PROPERTIES
   [BsonId]
   [BsonRepresentation(BsonType.ObjectId)]

   public string Id { get; set; }

   public string Suggestion { get; set; }

   public string Description { get; set; }

   public DateTime DateCreated { get; set; } = DateTime.UtcNow;

   public CategoryModel Category { get; set; }

   public BasicUserModel Author { get; set; }

   //to set unique value to avoid duplicate
   public HashSet<string> UserVotes { get; set; } = new();

   public StatusModel SuggestionStatus { get; set; }

   public string OwnerNotes { get; set; }

   public bool ApprovedForRelease { get; set; } = false;

   public bool Archived { get; set; } = false;

   public bool Rejected { get; set; } = false;
}
