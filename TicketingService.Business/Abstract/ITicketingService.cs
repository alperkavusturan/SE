using System;
using System.Collections.Generic;
using System.Text;
using TicketingService.Data.Models;

namespace TicketingService.Business.Abstract
{
    public interface ITicketingService
    {
        IEnumerable<TicketingRecord> GetTicketingRecords();
        IEnumerable<TicketingRecord> GetTicketingRecordsByStatus(int status);
        IEnumerable<TicketingRecord> GetTicketingRecordsByEvent(int eventId);
        IEnumerable<TicketingRecord> GetTicketingRecordsByEventAndStatus(int eventId, int status);
        IEnumerable<TicketingRecord> GetTicketingRecordsByProfile(int profileId);
        TicketingRecord GetTicketingRecordById(int id);
        int CreateTicketingRecord(TicketingRecord item);
        TicketingRecord EditTicketingRecord(TicketingRecord item);
    }
}
