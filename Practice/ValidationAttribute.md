**Validation Attribute**
***
```
<div>
  <label asp-for="Continent.Name"></label>
  <div>
    <input asp-for="Continent.Name" />
    <span asp-validation-for="Continent.Name"></span>
  </div>
</div>
```
The asp-for attribute in an <input> element will render
1. HTML and JavaScript that handle the display and data entry for a field based on the model annotations.
2. The JavaScript will set the valid flag on the field.

The asp-validation-for attribute in a <span> element will display any error message generated when the property annotations are not valid.

In this example, the <span> be rendered as this HTML:
```
<span class="field-validation-valid" data-valmsg-for="Continent.Name" data-valmsg-replace="true"></span>
```