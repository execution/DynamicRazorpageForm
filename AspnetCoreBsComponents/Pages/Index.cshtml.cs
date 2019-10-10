using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.ComponentModel.DataAnnotations;

namespace AspnetCoreBsComponents.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public PersonViewModel Person { get; set; } = new PersonViewModel();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                return;
            }

        }
    }
    public class PersonViewModel
    {
        [Display(Name = "Name :"), Required]
        public string Name { get; set; }

        [Display(Name = "Last Name :"), Required]
        public string LastName { get; set; }

        [Display(Name = "Age :"), Required]
        public int Age { get; set; }

        [Display(Name = "Date Of Birth :"), Required]
        public DateTime BirthDate { get; set; }
    }
}
