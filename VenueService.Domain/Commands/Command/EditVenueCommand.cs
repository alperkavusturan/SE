using VenueService.Data.Models;

namespace VenueService.Domain.Commands.Command
{
    public class EditVenueCommand : ICommand<Venue>
    {
        public Venue Venue { get; private set; }

        public EditVenueCommand(Venue item)
        {
            Venue = item;
        }
    }
}
