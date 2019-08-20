using ArtistService.Business.Abstract;
using ArtistService.Data.Models;
using ArtistService.Domain.Commands.Command;

namespace ArtistService.Domain.Commands.Handler
{
    public class EditArtistCommandHandler : ICommandHandler<EditArtistCommand, Artist>
    {
        readonly IArtistService _service;
        readonly EditArtistCommand _command;

        public EditArtistCommandHandler(IArtistService service, EditArtistCommand command)
        {
            _service = service;
            _command = command;
        }

        public Artist Execute()
        {
            return _service.EditArtist(_command.Artist);
        }
    }
}
