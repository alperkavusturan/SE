using EventService.Data.Models;
using System.Collections.Generic;

namespace EventService.Business.Abstract
{
    public interface IEventTypeService
    {
        IEnumerable<EventType> GetEventTypes();
        EventType GetEventTypeById(int id);
        int CreateEventType(EventType request);
        EventType EditEventType(EventType request);
        bool DeleteEventType(EventType request);
    }
}
