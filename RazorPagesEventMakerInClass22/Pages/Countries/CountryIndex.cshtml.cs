using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesEventMakerInClass22.Interfaces;
using RazorPagesEventMakerInClass22.Models;
using System.Diagnostics.Metrics;

namespace RazorPagesEventMakerInClass22.Pages.Countries
{
    public class CountryIndexModel : PageModel
    {
        private ICountryRepository _repository;
        public List<Country> Countries { get; set; }

        public CountryIndexModel(ICountryRepository conRepo)
        {
            _repository =  conRepo;
        }

        public void OnGet()
        {
            Countries = _repository.GetAllCountries();
        }
    }
}
