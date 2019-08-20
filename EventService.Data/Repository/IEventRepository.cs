using EventService.Data.Models;
using System.Collections.Generic;

namespace EventService.Data.Repository
{
    public interface IEventRepository
    {
        IEnumerable<Event> GetAll();
        IEnumerable<Event> GetByArtistId(int id);
        IEnumerable<Event> GetByVenueId(int id);
        Event GetById(int id);
        int Add(Event item);
        Event Update(Event item);
        bool Delete(Event item);
    }
}
