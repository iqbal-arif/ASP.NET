//LESSON 8

namespace SuggestionAppLibrary.Models;

public class BasicSuggestionModel
{
   [BsonRepresentation(BsonType.ObjectId)]

   public string Id { get; set; }

   public string Suggestion { get; set; }


   //CONSTRUCTOR FOR CREATE NEW OBJECT WITH ID & SUGGESITON TITLE

   //To crated a New Model
   public BasicSuggestionModel()
   {
      
   }

   //Pull the values from SuggestionModel
   public BasicSuggestionModel(SuggestionModel suggestion)
   {
      Id = suggestion.Id;
      Suggestion = suggestion.Suggestion;

      
   }
}
