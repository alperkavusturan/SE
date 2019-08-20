using ProfileService.Business.Abstract;
using ProfileService.Data.Models;
using ProfileService.Domain.Commands.Command;
using ProfileService.Domain.Commands.Handler;

namespace ProfileService.Domain.Commands
{
    public class ProfileCommandHandlerFactory
    {
        readonly IProfileService _service;

        public ProfileCommandHandlerFactory(IProfileService service)
        {
            _service = service;
        }

        public ICommandHandler<CreateProfileCommand, int> Build(CreateProfileCommand command)
        {
            return new CreateProfileCommandHandler(_service, command);
        }

        public ICommandHandler<EditProfileCommand, Profile> Build(EditProfileCommand command)
        {
            return new EditProfileCommandHandler(_service, command);
        }

        public ICommandHandler<DeleteProfileCommand, bool> Build(DeleteProfileCommand command)
        {
            return new DeleteProfileCommandHandler(_service, command);
        }
    }
}
