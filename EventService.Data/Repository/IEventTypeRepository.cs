using EventService.Data.Models;
using System.Collections.Generic;

namespace EventService.Data.Repository
{
    public interface IEventTypeRepository
    {
        IEnumerable<EventType> GetAll();
        EventType GetById(int id);
        int Add(EventType item);
        EventType Update(EventType item);
        bool Delete(EventType item);
    }
}
