using ProfileService.Business.Abstract;
using ProfileService.Data.Models;
using ProfileService.Domain.Commands.Command;

namespace ProfileService.Domain.Commands.Handler
{
    public class EditProfileCommandHandler : ICommandHandler<EditProfileCommand, Profile>
    {
        readonly IProfileService _service;
        readonly EditProfileCommand _command;

        public EditProfileCommandHandler(IProfileService service, EditProfileCommand command)
        {
            _service = service;
            _command = command;
        }

        public Profile Execute()
        {
            return _service.EditProfile(_command.Profile);
        }
    }
}
