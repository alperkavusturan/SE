using ArtistService.Data.Models;

namespace ArtistService.Domain.Commands.Command
{
    public class CreateArtistCommand : ICommand<int>
    {
        public Artist Artist { get; private set; }

        public CreateArtistCommand(Artist item)
        {
            Artist = item;
        }
    }
}
