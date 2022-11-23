using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesEventMakerInClass22.Interfaces;
using RazorPagesEventMakerInClass22.Models;

namespace RazorPagesEventMakerInClass22.Pages.Events
{
    public class DeleteEventModel : PageModel
    {
        private IRepository _repo;

        [BindProperty]
        public Event Event { get; set; }
        public DeleteEventModel(IRepository fakeRepo)
        {
            _repo = fakeRepo;
        }
        public void OnGet(int id)
        {
            Event = _repo.GetEvent(id);
        }

        public IActionResult OnPost()
        {
            _repo.DeleteEvent(Event.Id);
            return RedirectToPage("Index");
        }
    }
}
