

namespace SuggestionAppLibrary.Models;

public class BasicSuggestionModel
{
   [BsonRepresentation(BsonType.ObjectId)]

   public int Id { get; set; }

   public string Suggestion { get; set; }


   //CONSTRUCTOR


   public BasicSuggestionModel()
   {
      
   }

   public BasicSuggestionModel(SuggestionModel suggestion)
   {
      var Id = suggestion.Id;
   }
}
