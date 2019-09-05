using System;
using System.Collections.Generic;
using System.Text;
using TicketingService.Data.Models;

namespace TicketingService.Data.Repository
{
    public interface ITicketingRepository
    {
        IEnumerable<TicketingRecord> GetAll();
        IEnumerable<TicketingRecord> GetByStatus(int status);
        IEnumerable<TicketingRecord> GetByEvent(int eventId);
        IEnumerable<TicketingRecord> GetByEventAndStatus(int eventId, int status);
        IEnumerable<TicketingRecord> GetByProfile(int profileId);
        TicketingRecord GetById(int id);
        int Add(TicketingRecord item);
        TicketingRecord Update(TicketingRecord item);
    }
}
