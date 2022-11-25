using RazorPagesEventMakerInClass22.Helpers;
using RazorPagesEventMakerInClass22.Interfaces;
using RazorPagesEventMakerInClass22.Models;

namespace RazorPagesEventMakerInClass22.Services
{
    public class JsonCountryRepository : ICountryRepository
    {
        string filePath = @"Data\JsonCountries.json";
        public void AddCountry(Country country)
        {
            throw new NotImplementedException();
        }

        public void DeleteCountry(string code)
        {
            throw new NotImplementedException();
        }

        public List<Country> GetAllCountries()
        {
            return JsonFileReader.ReadJsonCountries(filePath);
        }

        public Country GetCountry(string code)
        {
            List<Country> countries = GetAllCountries();
            foreach (Country c in countries)
            {
                if (c.Code == code)
                {
                    return c;
                }
            }
            return new Country();
        }
    }
}
