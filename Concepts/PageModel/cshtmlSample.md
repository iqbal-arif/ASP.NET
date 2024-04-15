Page Model : Pizza.cshtml.cs 
```
//Pizza.cshtml.cs file
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace starting_app.Pages
{
  public class PizzaModel : PageModel
  {
    public double PizzaTotal (string pizzaType)
    {
      Dictionary<string, double> PizzaCost = new Dictionary<string, double>()
      {
        { "Cheese", 10 },
        { "Pepperoni", 11 },
        { "Vegetarian", 12 },
      };
      
      return PizzaCost[pizzaType];
    }

    public double Total {get; set;}
    public string Customer {get; set;}
    public string Order {get; set;}
    public bool ExtraCheese {get; set;}

    public void OnGet()
    {
      Customer = "Arif Iqbal";
      Order = "Cheese";
      ExtraCheese = false;
      Total = PizzaTotal("Cheese");
    }
  }
}

```
Page View : Pizza.cshtml

```
@page
<!-- Specify the model below -->
@model PizzaModel
@{
}

<h1 class="text-center">Codecademy Pizza</h1>
<br>
<div class="card mx-auto" style="width: 18rem;">
  <img src="https://static-assets.codecademy.com/curriculum/asp/pizza.svg" class="card-img-top-center" alt="pizza icon" style="width: 50px; height: 50px;">
  <div class="card-body">
    <h4 class="card-title text-center">Confirm your order</h4>
    <br>
		<h5>Pizza for: @Model.Customer</h5>
		<h5>Order: @Model.Order</h5>
    <h5>Extra Cheese: @Model.ExtraCheese</h5>
		<h5>Total: $@String.Format("{0:0.00}", Model.Total)</h5>
    <br>
    <a href="#" class="btn btn-primary">Place Order</a>
  </div>
</div>
```