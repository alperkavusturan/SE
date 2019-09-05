using System;
using System.Collections.Generic;
using System.Text;
using TicketingService.Data.Models;

namespace TicketingService.Domain.Commands.Command
{
    public class EditTicketingRecordCommand : ICommand<TicketingRecord>
    {
        public TicketingRecord TicketingRecord { get; set; }

        public EditTicketingRecordCommand(TicketingRecord item)
        {
            TicketingRecord = item;
        }
    }
}
