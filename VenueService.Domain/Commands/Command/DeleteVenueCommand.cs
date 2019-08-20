using VenueService.Data.Models;

namespace VenueService.Domain.Commands.Command
{
    public class DeleteVenueCommand : ICommand<bool>
    {
        public Venue Venue { get; private set; }

        public DeleteVenueCommand(Venue item)
        {
            Venue = item;
        }
    }
}
