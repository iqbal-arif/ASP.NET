**[DataType] Attribute**
***
```
using System.ComponentModel.DataAnnotations;
    
public class Country
{
  [DataType(DataType.Date)]
  [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
  public DateTime? UnitedNationsDate { get; set; }
}
```
The [DataType] attribute specifies a more specific data type than the database column type. In this case, the database table will use a DateTime column but the render logic will only show the date.

The @Html.DisplayFor() helper knows about types and will render a default format to match the type. In this case, the HTML5 browser date picker will appear when editing the field.
