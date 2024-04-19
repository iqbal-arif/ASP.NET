using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        //Data are not passed directly to onGet() or onPost()
        //Insead use properties that can be Read my Index.cshtml
        //PROPERTIES
        [BindProperty(SupportsGet =true)] // allows to write value to it through onPost()method
        //SupportGet=true allows to HTTP Get Method to be displayed.
        public string City { get; set; } // will display on index page
        public void OnGet()
        {
            if (string.IsNullOrEmpty(City))
            {
                City = "The Web";
            }
        }
    }
}
