using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesEventMakerInClass22.Interfaces;
using RazorPagesEventMakerInClass22.Models;

namespace RazorPagesEventMakerInClass22.Pages.Hotels
{
    public class IndexModel : PageModel
    {
        private IHotelRepository repo;
        public List<Hotel> Hotels { get; set; }

        public IndexModel(IHotelRepository hotelRepository)
        {
            repo = hotelRepository;
        }
        public void OnGet()
        {
            Hotels = repo.GetAllHotels();
        }
    }
}
