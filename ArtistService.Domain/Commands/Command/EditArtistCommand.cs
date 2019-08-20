using ArtistService.Data.Models;

namespace ArtistService.Domain.Commands.Command
{
    public class EditArtistCommand : ICommand<Artist>
    {
        public Artist Artist { get; private set; }

        public EditArtistCommand(Artist item)
        {
            Artist = item;
        }
    }
}
