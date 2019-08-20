using ProfileService.Data.Models;

namespace ProfileService.Domain.Commands.Command
{
    public class CreateProfileCommand : ICommand<int>
    {
        public Profile Profile { get; private set; }

        public CreateProfileCommand(Profile item)
        {
            Profile = item;
        }
    }
}
