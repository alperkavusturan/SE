using ProfileService.Business.Abstract;
using ProfileService.Domain.Commands.Command;

namespace ProfileService.Domain.Commands.Handler
{
    public class CreateProfileCommandHandler : ICommandHandler<CreateProfileCommand, int>
    {
        readonly IProfileService _service;
        readonly CreateProfileCommand _command;

        public CreateProfileCommandHandler(IProfileService service, CreateProfileCommand command)
        {
            _service = service;
            _command = command;
        }
        public int Execute()
        {
            return _service.CreateProfile(_command.Profile);
        }
    }
}
