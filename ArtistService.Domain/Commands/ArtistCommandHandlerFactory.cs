using ArtistService.Business.Abstract;
using ArtistService.Data.Models;
using ArtistService.Domain.Commands.Command;
using ArtistService.Domain.Commands.Handler;

namespace ArtistService.Domain.Commands
{
    public class ArtistCommandHandlerFactory
    {
        readonly IArtistService _service;

        public ArtistCommandHandlerFactory(IArtistService service)
        {
            _service = service;
        }

        public ICommandHandler<CreateArtistCommand, int> Build(CreateArtistCommand command)
        {
            return new CreateArtistCommandHandler(_service, command);
        }

        public ICommandHandler<EditArtistCommand, Artist> Build(EditArtistCommand command)
        {
            return new EditArtistCommandHandler(_service, command);
        }

        public ICommandHandler<DeleteArtistCommand, bool> Build(DeleteArtistCommand command)
        {
            return new DeleteArtistCommandHandler(_service, command);
        }
    }
}
