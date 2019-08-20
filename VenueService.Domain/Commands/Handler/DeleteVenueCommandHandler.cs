using VenueService.Business.Abstract;
using VenueService.Domain.Commands.Command;

namespace VenueService.Domain.Commands.Handler
{
    public class DeleteVenueCommandHandler : ICommandHandler<DeleteVenueCommand, bool>
    {
        readonly IVenueService _service;
        readonly DeleteVenueCommand _command;

        public DeleteVenueCommandHandler(IVenueService service, DeleteVenueCommand command)
        {
            _service = service;
            _command = command;
        }
        public bool Execute()
        {
            return _service.DeleteVenue(_command.Venue);
        }
    }
}
