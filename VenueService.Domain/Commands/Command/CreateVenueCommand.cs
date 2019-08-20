using VenueService.Data.Models;

namespace VenueService.Domain.Commands.Command
{
    public class CreateVenueCommand : ICommand<int>
    {
        public Venue Venue { get; private set; }

        public CreateVenueCommand(Venue item)
        {
            Venue = item;
        }
    }
}
