

namespace SuggestionAppLibrary.Models;

public class BasicUserModel
{
   [BsonRepresentation(BsonType.ObjectId)]

   public string Id { get; set; }

   public string DisplayName { get; set; }


   //CONSTRUCTOR

   public BasicUserModel()
   {
      
   }

   public BasicUserModel(UserModel user)
   {
      Id = user.Id;
      DisplayName = user.DisplayName;
   }
}
