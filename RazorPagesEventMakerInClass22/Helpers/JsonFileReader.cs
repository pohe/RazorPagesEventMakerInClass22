using RazorPagesEventMakerInClass22.Models;
using System.Text.Json;

namespace RazorPagesEventMakerInClass22.Helpers
{
    public class JsonFileReader
    {
        public static List<Event> ReadJson(string jsonFileName)
        {
            using (var jsonFileReader = File.OpenText(jsonFileName))
            {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<Event>>(indata);
            }
        }

    }

}
