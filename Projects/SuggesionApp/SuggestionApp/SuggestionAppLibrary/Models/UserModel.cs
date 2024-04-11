//LESSON 8

namespace SuggestionAppLibrary.Models;
public class UserModel
{
   //ID from MongoDb
   [BsonId]
   [BsonRepresentation(BsonType.ObjectId)]

   public string Id { get; set; }

   //ID  from Azure Active Directory to Identify the User

   public string ObjectIdentifier { get; set; }

   public string FirstName { get; set; }

   public string LastName { get; set; }

   public string DisplayName { get; set; }

   public string EmailAddress { get; set; }   


   //List of Suggestion Author as you have created
   public List<BasicSuggestionModel> AuthoredSuggestions { get; set; } = new ();

   public List<BasicSuggestionModel> VotedOnSuggestions { get; set; } = new ();
      
}
