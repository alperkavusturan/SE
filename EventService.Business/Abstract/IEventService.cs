using EventService.Data.Models;
using System.Collections.Generic;

namespace EventService.Business.Abstract
{
    public interface IEventService
    {
        IEnumerable<Event> GetEvents();
        IEnumerable<Event> GetEventsByArtistId(int id);
        IEnumerable<Event> GetEventsByVenueId(int id);
        Event GetEventById(int id);
        int CreateEvent(Event request);
        Event EditEvent(Event request);
        bool DeleteEvent(Event request);
    }
}
