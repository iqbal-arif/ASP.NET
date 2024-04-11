//LESSON 8
namespace SuggestionAppLibrary.Models;
public class CategoryModel
{
   //PROPERTIES
   //Identifier
   [BsonId]
   //ObjectId assigned a value when inserting into MongoDb
   [BsonRepresentation(BsonType.ObjectId)]
   public string Id { get; set; }

   public string CategoryName { get; set; }

   public string CategoryDescription { get; set; }
}
