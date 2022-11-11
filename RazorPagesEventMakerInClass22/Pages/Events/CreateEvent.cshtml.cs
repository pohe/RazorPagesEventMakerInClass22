using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesEventMakerInClass22.Interfaces;
using RazorPagesEventMakerInClass22.Models;

namespace RazorPagesEventMakerInClass22.Pages.Events
{
    public class CreateEventModel : PageModel
    {
        private IRepository repo;

        [BindProperty]
        public Event Event{ get; set; }

        public CreateEventModel(IRepository fakeEventRepository)
        {
            repo = fakeEventRepository;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            repo.AddEvent(Event);
            return RedirectToPage("Index");
        }
    }
}
