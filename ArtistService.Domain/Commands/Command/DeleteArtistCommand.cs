using ArtistService.Data.Models;

namespace ArtistService.Domain.Commands.Command
{
    public class DeleteArtistCommand : ICommand<bool>
    {
        public Artist Artist { get; private set; }

        public DeleteArtistCommand(Artist item)
        {
            Artist = item;
        }
    }
}
