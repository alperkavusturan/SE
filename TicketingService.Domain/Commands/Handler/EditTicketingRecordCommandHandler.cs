using TicketingService.Business.Abstract;
using TicketingService.Data.Models;
using TicketingService.Domain.Commands.Command;

namespace TicketingService.Domain.Commands.Handler
{
    public class EditTicketingRecordCommandHandler : ICommandHandler<EditTicketingRecordCommand, TicketingRecord>
    {
        readonly ITicketingService _service;
        readonly EditTicketingRecordCommand _command;

        public EditTicketingRecordCommandHandler(ITicketingService service, EditTicketingRecordCommand command)
        {
            _service = service;
            _command = command;
        }

        public TicketingRecord Execute()
        {
            return _service.EditTicketingRecord(_command.TicketingRecord);
        }
    }
}
