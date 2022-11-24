using RazorPagesEventMakerInClass22.Models;
using System.Text.Json;

namespace RazorPagesEventMakerInClass22.Helpers
{
    public class JsonFileWriter
    {
        public static void WritetoJson(List<Event> events, string jsonFileName)
        {
            //using(FileStream outputStream =File.OpenWrite(jsonFileName))
            using (FileStream outputStream = File.Create(jsonFileName))
            {
                var writter = new Utf8JsonWriter(outputStream, new JsonWriterOptions
                {
                    SkipValidation = false,
                    Indented = true,
                });
                JsonSerializer.Serialize<Event[]>(writter, events.ToArray());
            }
        }

    }

}
