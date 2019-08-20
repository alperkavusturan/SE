using ProfileService.Data.Models;

namespace ProfileService.Domain.Commands.Command
{
    public class EditProfileCommand : ICommand<Profile>
    {
        public Profile Profile { get; private set; }

        public EditProfileCommand(Profile item)
        {
            Profile = item;
        }
    }
}
