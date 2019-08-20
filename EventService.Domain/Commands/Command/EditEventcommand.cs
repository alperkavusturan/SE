using EventService.Data.Models;

namespace EventService.Domain.Commands.Command
{
    public class EditEventCommand : ICommand<Event>
    {
        public Event Event { get; private set; }

        public EditEventCommand(Event item)
        {
            Event = item;
        }
    }
}
