using RazorPagesEventMakerInClass22.Interfaces;
using RazorPagesEventMakerInClass22.Models;

namespace RazorPagesEventMakerInClass22.Services
{
    public class FakeEventRepository : IRepository
    {
        private List<Event> events { get; }

        public FakeEventRepository()
        {
            events = new List<Event>();
            events.Add(new Event()
            {
                Id = 1,
                Name = "Roskilde Festival",
                Description = " A lot of music",
                City = "Roskilde",
                DateTime = new DateTime(2020, 6, 9, 10, 0, 0)
            });
            events.Add(new Event()
            {
                Id = 2,
                Name = "CPH Marathon",
                Description = " Many Marathon runners",
                City = "Copenhagen",
                DateTime = new DateTime(2020, 3, 6, 9, 30, 0)
            });
            events.Add(new Event()
            {
                Id = 3,
                Name = "CPH Distorsion",
                Description = " A lot of beers",
                City = "Copenhagen",
                DateTime = new DateTime(2019, 6, 4, 14, 0, 0)
            });
            events.Add(new Event()
            {
                Id = 4,
                Name = "Demo Day",
                Description = "Project Presentation",
                City = "Roskilde",
                DateTime = new DateTime(2020, 6, 9, 9, 0, 0)
            });
            events.Add(new Event()
            {
                Id = 5,
                Name = "VM Badminton",
                Description = "Badminton",
                City = "Århus",
                DateTime = new DateTime(2020, 10, 3, 16, 0, 0)
            });
        }

        public List<Event> GetAllEvents()
        {
            return events.ToList();
        }

        public void AddEvent(Event aEvent)
        {
            //List<int> eventIds = new List<int>();
            //foreach(var evt in events)
            //{
            //    eventIds.Add(evt.Id);
            //}
            //if (eventIds.Count!=0)
            //{
            //    int start = eventIds.Max();
            //    aEvent.Id = start + 1; 
            //}
            //else
            //{
            //    aEvent.Id = 1;
            //}
            events.Add(aEvent);
        }

        public Event GetEvent(int id)
        {
            foreach (Event aEvent in events)
            {
                if (aEvent.Id == id)
                {
                    return aEvent;
                }
            }
            return new Event();
        }

        public void UpdateEvent(Event ev)
        {
            if (ev != null)
            {
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
            }
        }

        public void DeleteEvent(int id)
        {
            Event eventToDelete = GetEvent(id);
            events.Remove(eventToDelete);
        }

        public List<Event> FilterEvents(string filter)
        {
            List<Event> filteredList = new List<Event>();
            foreach (var item in events)
            {
                if ( item.City.Contains(filter) || item.Name.Contains(filter) || item.Description.Contains(filter))
                {
                    filteredList.Add(item);
                }
            }
            return filteredList;    
        }

        public List<Event> GetAllEventsByCode(string code)
        {
            throw new NotImplementedException();
        }
    }
}
