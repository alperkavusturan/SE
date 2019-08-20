using EventService.Business.Abstract;
using EventService.Data.Models;
using EventService.Domain.Commands.Command;

namespace EventService.Domain.Commands.Handler
{
    public class EditEventCommandHandler : ICommandHandler<EditEventCommand, Event>
    {
        readonly IEventService _service;
        readonly EditEventCommand _command;

        public EditEventCommandHandler(IEventService service, EditEventCommand command)
        {
            _service = service;
            _command = command;
        }

        public Event Execute()
        {
            return _service.EditEvent(_command.Event);
        }
    }
}
