using System;

/// <summary>
/// Summary description for DishIngredient
/// </summary>
public class DishIngredient
{
    //PROPERTIES
    public int DishId { get; set; }

    public Menu.Models.Dish Dish { get; set; }

    public int IngredientId { get; set; }

    public  Ingredient Ingredient { get; set; }

}
