using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesUI.Models;

namespace RazorPagesUI.Pages.Forms
{
    public class AddAddressModel : PageModel
    {
        //PROPERTIES
        [BindProperty] //This bindproperty picks all the property without get method
        public AddressModel Address { get; set; }


        public void OnGet()
        {
        }


        //Capture the UI information through onPost()
        //IActionResult is method to ouput the post; refresh page, go to other page
        public IActionResult OnPost() 
        {
            //ModleState to check if input fields are enterend correctly
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            //TODO: Save Model to Database

            //Routes to Index (Homepage) and Route vaues to anonymous Object to display the city that was entered in AddAddress URL
            return RedirectToPage("/Index", new {Address.City});
        }
    }
}
