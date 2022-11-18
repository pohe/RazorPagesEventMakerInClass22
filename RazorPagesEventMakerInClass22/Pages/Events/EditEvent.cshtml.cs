using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesEventMakerInClass22.Models;

namespace RazorPagesEventMakerInClass22.Pages.Events
{
    public class EditEventModel : PageModel
    {
        [BindProperty]
        public Event Event { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return Page();
        }
    }
}
