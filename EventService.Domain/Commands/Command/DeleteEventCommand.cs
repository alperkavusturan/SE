using EventService.Data.Models;

namespace EventService.Domain.Commands.Command
{
    public class DeleteEventCommand : ICommand<bool>
    {
        public Event Event { get; private set; }

        public DeleteEventCommand(Event item)
        {
            Event = item;
        }
    }
}
