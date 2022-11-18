using RazorPagesEventMakerInClass22.Models;
using System.ComponentModel;

namespace RazorPagesEventMakerInClass22.Interfaces
{
    public interface IRepository
    {
        List<Event> GetAllEvents();
        Event GetEvent(int id);

        void AddEvent(Event ev);

        void UpdateEvent(Event ev);
    }
}
