using ArtistService.Business.Abstract;
using ArtistService.Domain.Commands.Command;

namespace ArtistService.Domain.Commands.Handler
{
    public class CreateArtistCommandHandler : ICommandHandler<CreateArtistCommand, int>
    {
        readonly IArtistService _service;
        readonly CreateArtistCommand _command;

        public CreateArtistCommandHandler(IArtistService service, CreateArtistCommand command)
        {
            _service = service;
            _command = command;
        }
        public int Execute()
        {
            return _service.CreateArtist(_command.Artist);
        }
    }
}
