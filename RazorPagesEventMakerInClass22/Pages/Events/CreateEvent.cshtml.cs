using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesEventMakerInClass22.Models;

namespace RazorPagesEventMakerInClass22.Pages.Events
{
    public class CreateEventModel : PageModel
    {
        private FakeEventRepository repo;

        [BindProperty]
        public Event Event{ get; set; }

        public CreateEventModel()
        {
            repo = new FakeEventRepository();
        }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            repo.Add(Event);
        }
    }
}
