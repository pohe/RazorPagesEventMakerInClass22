using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesEventMakerInClass22.Interfaces;
using RazorPagesEventMakerInClass22.Models;

namespace RazorPagesEventMakerInClass22.Pages.Events
{
    public class EditEventModel : PageModel
    {
        private IRepository repo;

        [BindProperty]
        public Event Event { get; set; }

        public EditEventModel(IRepository fakeeventRepo)
        {
            repo = fakeeventRepo;
        }

        public void OnGet(int id)
        {
            Event = repo.GetEvent(id);
        }

        public IActionResult OnPost()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}
            repo.UpdateEvent(Event);
            return RedirectToPage("Index");
        }

        //public IActionResult OnPostDelete()
        //{
        //    //if (!ModelState.IsValid)
        //    //{
        //    //    return Page();
        //    //}
        //    repo.DeleteEvent(Event.Id);
        //    return RedirectToPage("Index");
        //}
    }
}
