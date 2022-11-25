using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesEventMakerInClass22.Interfaces;
using RazorPagesEventMakerInClass22.Models;

namespace RazorPagesEventMakerInClass22.Pages.Countries
{
    public class CountryEventsModel : PageModel
    {
        private ICountryRepository _repo; 
        public Country Country { get; set; }

        public CountryEventsModel(ICountryRepository conRepo)
        {
            _repo = conRepo;
        }

        public void OnGet(string code)
        {
            Country = _repo.GetCountry(code);
        }
    }
}
