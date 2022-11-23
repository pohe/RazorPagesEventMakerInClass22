using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesEventMakerInClass22.Interfaces;
using RazorPagesEventMakerInClass22.Models;

namespace RazorPagesEventMakerInClass22.Pages.Events
{
    public class IndexModel : PageModel
    {
        private IRepository _repository;

        [BindProperty]
        public string FilterCriteria { get; set; }
        public List<Event> Events { get; private set; }
        public IndexModel(IRepository fakeEventRepository)
        {
            _repository = fakeEventRepository;
        }

        public void OnGet()
        {
            Events = _repository.GetAllEvents();
        }

        public void OnPost()
        {
            if (FilterCriteria != null)
                Events = _repository.FilterEvents(FilterCriteria);
            else
                Events = _repository.GetAllEvents();
        }
    }
}
