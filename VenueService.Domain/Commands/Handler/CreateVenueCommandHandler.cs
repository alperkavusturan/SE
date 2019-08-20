using VenueService.Business.Abstract;
using VenueService.Domain.Commands.Command;

namespace VenueService.Domain.Commands.Handler
{
    public class CreateVenueCommandHandler : ICommandHandler<CreateVenueCommand, int>
    {
        readonly IVenueService _service;
        readonly CreateVenueCommand _command;

        public CreateVenueCommandHandler(IVenueService service, CreateVenueCommand command)
        {
            _service = service;
            _command = command;
        }
        public int Execute()
        {
            return _service.CreateVenue(_command.Venue);
        }
    }
}
