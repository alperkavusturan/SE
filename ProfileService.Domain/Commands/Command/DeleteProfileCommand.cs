using ProfileService.Data.Models;

namespace ProfileService.Domain.Commands.Command
{
    public class DeleteProfileCommand : ICommand<bool>
    {
        public Profile Profile { get; private set; }

        public DeleteProfileCommand(Profile item)
        {
            Profile = item;
        }
    }
}
