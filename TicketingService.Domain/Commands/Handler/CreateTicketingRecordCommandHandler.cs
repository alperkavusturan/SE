using System;
using System.Collections.Generic;
using System.Text;
using TicketingService.Business.Abstract;
using TicketingService.Domain.Commands.Command;

namespace TicketingService.Domain.Commands.Handler
{
    public class CreateTicketingRecordCommandHandler : ICommandHandler<CreateTicketingRecordCommand, int>
    {
        readonly ITicketingService _service;
        readonly CreateTicketingRecordCommand _command;

        public CreateTicketingRecordCommandHandler(ITicketingService service, CreateTicketingRecordCommand command)
        {
            _service = service;
            _command = command;
        }
        public int Execute()
        {
            return _service.CreateTicketingRecord(_command.TicketingRecord);
        }
    }
}
