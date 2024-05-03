**[StringLength] Attribute**
***
```
using System.ComponentModel.DataAnnotations;
    
public class Country
{
  [StringLength(2, MinimumLength = 2)]
  public string ContinentCode { get; set; }
}
```
The [StringLength] attribute specifies the maximum length of characters that are allowed in a data field and optionally the minimum length. The model will not be flagged as valid if these restrictions are exceeded. In this case, the ContinentID must be exactly 2 characters in length.

In a Razor Page, 

1. the @Html.DisplayFor() helper only shows the data in the field.
1. The client-side JavaScript validation scripts use the asp-validation-for attribute on a <span> tag to display a default error message.
