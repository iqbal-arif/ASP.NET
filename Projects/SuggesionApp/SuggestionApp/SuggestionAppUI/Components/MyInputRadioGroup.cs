using Microsoft.AspNetCore.Components.Forms;
namespace SuggestionAppUI.Components;
//LESSON 16 : Custom Component due to Click Registration issues with InputRadioGroup
//The Radio Button has to be clicked twice in order to make it active. Some rendering issue. This custom component take cares of this issue. A Workaround.
public class MyInputRadioGroup<TValue> : InputRadioGroup<TValue>
{
   private string _name;
   private string _fieldClass;


   protected override void OnParametersSet()
   {
      
      {
         var fieldClass = EditContext?.FieldCssClass(FieldIdentifier) ?? string.Empty;
         if (fieldClass != _fieldClass || Name != _name) 
         {
            _fieldClass = fieldClass;
            _name = Name;
            base.OnParametersSet();
         }
      }
   }
}
