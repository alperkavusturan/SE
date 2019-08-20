using EventService.Business.Abstract;
using EventService.Domain.Commands.Command;

namespace EventService.Domain.Commands.Handler
{
    public class DeleteEventCommandHandler : ICommandHandler<DeleteEventCommand, bool>
    {
        readonly IEventService _service;
        readonly DeleteEventCommand _command;

        public DeleteEventCommandHandler(IEventService service, DeleteEventCommand command)
        {
            _service = service;
            _command = command;
        }
        public bool Execute()
        {
            return _service.DeleteEvent(_command.Event);
        }
    }
}
