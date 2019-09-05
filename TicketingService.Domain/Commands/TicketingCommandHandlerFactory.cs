using System;
using System.Collections.Generic;
using System.Text;
using TicketingService.Business.Abstract;
using TicketingService.Data.Models;
using TicketingService.Domain.Commands.Command;
using TicketingService.Domain.Commands.Handler;

namespace TicketingService.Domain.Commands
{
    public class TicketingCommandHandlerFactory
    {
        readonly ITicketingService _service;

        public TicketingCommandHandlerFactory(ITicketingService service)
        {
            _service = service;
        }

        public ICommandHandler<CreateTicketingRecordCommand, int> Build(CreateTicketingRecordCommand command)
        {
            return new CreateTicketingRecordCommandHandler(_service, command);
        }

        public ICommandHandler<EditTicketingRecordCommand, TicketingRecord> Build(EditTicketingRecordCommand command)
        {
            return new EditTicketingRecordCommandHandler(_service, command);
        }

    }
}
