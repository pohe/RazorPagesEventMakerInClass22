using RazorPagesEventMakerInClass22.Interfaces;
using RazorPagesEventMakerInClass22.Models;
using RazorPagesEventMakerInClass22.Helpers;
using Microsoft.Extensions.Logging;

namespace RazorPagesEventMakerInClass22.Services
{
    public class JsonEventRepository : IRepository
    {

        string jsonFileName = @"Data\JsonEvents.json";
        public void AddEvent(Event ev)
        { 
            List<Event> events = GetAllEvents();
            events.Add(ev);
            JsonFileWriter.WritetoJson(events,jsonFileName);
        }

        public void DeleteEvent(int id)
        {
            Event eventToDelete = GetEvent(id);
            List<Event> events = GetAllEvents();
            events.Remove(eventToDelete);
            JsonFileWriter.WritetoJson(events, jsonFileName);
        }

        public List<Event> FilterEvents(string filter)
        {
            List<Event> filteredList = new List<Event>();
            foreach (var item in GetAllEvents())
            {
                if (item.City.Contains(filter) || item.Name.Contains(filter) || item.Description.Contains(filter))
                {
                    filteredList.Add(item);
                }
            }
            return filteredList;
        }

        public List<Event> GetAllEvents()
        {
            return JsonFileReader.ReadJson(jsonFileName);
        }

        public Event GetEvent(int id)
        {
            List<Event> events = GetAllEvents();
            foreach (Event item in events)
            {
                if (item.Id == id)
                    return item;
            }
            return new Event();
        }

        public void UpdateEvent(Event ev)
        {
            if (ev != null)
            {
                List<Event> events = GetAllEvents();
                foreach (Event e in events)
                {
                    if (e.Id == ev.Id)
                    {
                        e.Id = ev.Id;
                        e.Name = ev.Name;
                        e.Description = ev.Description;
                        e.City = ev.City;
                        e.DateTime = ev.DateTime;
                    }
                }
                JsonFileWriter.WritetoJson(events, jsonFileName);
            }
        }
    }
}
