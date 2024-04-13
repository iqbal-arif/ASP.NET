using System.ComponentModel.DataAnnotations;

namespace SuggestionAppUI.Models;

//LESSON 16

//CreatSuggesionModel UI Specific need; otherwise we could have used SuggestionModel from AppLibrary
public class CreateSuggestionModel
{
   [Required]
   [MaxLength(75)]
   public string Suggestion { get; set; }

   [Required]
   [MinLength(1)]
   [Display(Name ="Category")]
   public string CategoryId { get; set; }

   [MaxLength(500)]
   public string Description { get; set; }
}
