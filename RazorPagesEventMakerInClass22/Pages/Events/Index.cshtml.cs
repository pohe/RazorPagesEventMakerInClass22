using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesEventMakerInClass22.Models;

namespace RazorPagesEventMakerInClass22.Pages.Events
{
    public class IndexModel : PageModel
    {
        private FakeEventRepository _repository;

        public List<Event> Events { get; private set; }
        public IndexModel()
        {
            _repository = new FakeEventRepository();
        }

        public void OnGet()
        {
        }
    }
}
