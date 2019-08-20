using EventService.Data.Models;

namespace EventService.Domain.Commands.Command
{
    public class CreateEventCommand : ICommand<int>
    {
        public Event Event { get; private set; }

        public CreateEventCommand(Event item)
        {
            Event = item;
        }
    }
}
