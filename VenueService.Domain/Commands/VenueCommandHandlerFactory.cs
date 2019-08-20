using VenueService.Business.Abstract;
using VenueService.Data.Models;
using VenueService.Domain.Commands.Command;
using VenueService.Domain.Commands.Handler;

namespace VenueService.Domain.Commands
{
    public class VenueCommandHandlerFactory
    {
        readonly IVenueService _service;

        public VenueCommandHandlerFactory(IVenueService service)
        {
            _service = service;
        }

        public ICommandHandler<CreateVenueCommand, int> Build(CreateVenueCommand command)
        {
            return new CreateVenueCommandHandler(_service, command);
        }

        public ICommandHandler<EditVenueCommand, Venue> Build(EditVenueCommand command)
        {
            return new EditVenueCommandHandler(_service, command);
        }

        public ICommandHandler<DeleteVenueCommand, bool> Build(DeleteVenueCommand command)
        {
            return new DeleteVenueCommandHandler(_service, command);
        }
    }
}
