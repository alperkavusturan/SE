using EventService.Business.Abstract;
using EventService.Data.Models;
using EventService.Domain.Commands.Command;
using EventService.Domain.Commands.Handler;

namespace EventService.Domain.Commands
{
    public class EventCommandHandlerFactory
    {
        readonly IEventService _service;

        public EventCommandHandlerFactory(IEventService service)
        {
            _service = service;
        }

        public ICommandHandler<CreateEventCommand, int> Build(CreateEventCommand command)
        {
            return new CreateEventCommandHandler(_service, command);
        }

        public ICommandHandler<EditEventCommand, Event> Build(EditEventCommand command)
        {
            return new EditEventCommandHandler(_service, command);
        }

        public ICommandHandler<DeleteEventCommand, bool> Build(DeleteEventCommand command)
        {
            return new DeleteEventCommandHandler(_service, command);
        }

    }
}
