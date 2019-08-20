using ArtistService.Business.Abstract;
using ArtistService.Domain.Commands.Command;

namespace ArtistService.Domain.Commands.Handler
{
    public class DeleteArtistCommandHandler : ICommandHandler<DeleteArtistCommand, bool>
    {
        readonly IArtistService _service;
        readonly DeleteArtistCommand _command;

        public DeleteArtistCommandHandler(IArtistService service, DeleteArtistCommand command)
        {
            _service = service;
            _command = command;
        }
        public bool Execute()
        {
            return _service.DeleteArtist(_command.Artist);
        }
    }
}
