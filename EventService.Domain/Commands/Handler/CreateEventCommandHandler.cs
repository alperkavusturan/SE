using EventService.Business.Abstract;
using EventService.Domain.Commands.Command;

namespace EventService.Domain.Commands.Handler
{
    public class CreateEventCommandHandler : ICommandHandler<CreateEventCommand, int>
    {
        readonly IEventService _service;
        readonly CreateEventCommand _command;

        public CreateEventCommandHandler(IEventService service, CreateEventCommand command)
        {
            _service = service;
            _command = command;
        }
        public int Execute()
        {
            return _service.CreateEvent(_command.Event);
        }
    }
}
