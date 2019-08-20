using VenueService.Business.Abstract;
using VenueService.Data.Models;
using VenueService.Domain.Commands.Command;

namespace VenueService.Domain.Commands.Handler
{
    public class EditVenueCommandHandler : ICommandHandler<EditVenueCommand, Venue>
    {
        readonly IVenueService _service;
        readonly EditVenueCommand _command;

        public EditVenueCommandHandler(IVenueService service, EditVenueCommand command)
        {
            _service = service;
            _command = command;
        }

        public Venue Execute()
        {
            return _service.EditVenue(_command.Venue);
        }
    }
}
