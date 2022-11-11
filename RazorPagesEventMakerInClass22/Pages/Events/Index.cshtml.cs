using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesEventMakerInClass22.Interfaces;
using RazorPagesEventMakerInClass22.Models;

namespace RazorPagesEventMakerInClass22.Pages.Events
{
    public class IndexModel : PageModel
    {
        private IRepository _repository;

        public List<Event> Events { get; private set; }
        public IndexModel(IRepository fakeEventRepository)
        {
            _repository = fakeEventRepository;
        }

        public void OnGet()
        {
            Events = _repository.GetAllEvents();
        }
    }
}
