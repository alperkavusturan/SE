using System;
using System.Collections.Generic;
using System.Text;
using TicketingService.Data.Models;

namespace TicketingService.Domain.Commands.Command
{
    public class CreateTicketingRecordCommand : ICommand<int>
    {
        public TicketingRecord TicketingRecord { get; set; }

        public CreateTicketingRecordCommand(TicketingRecord item)
        {
            TicketingRecord = item;
        }
    }
}
