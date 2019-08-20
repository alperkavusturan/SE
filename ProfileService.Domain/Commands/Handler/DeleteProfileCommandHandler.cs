using ProfileService.Business.Abstract;
using ProfileService.Domain.Commands.Command;

namespace ProfileService.Domain.Commands.Handler
{
    public class DeleteProfileCommandHandler : ICommandHandler<DeleteProfileCommand, bool>
    {
        readonly IProfileService _service;
        readonly DeleteProfileCommand _command;

        public DeleteProfileCommandHandler(IProfileService service, DeleteProfileCommand command)
        {
            _service = service;
            _command = command;
        }
        public bool Execute()
        {
            return _service.DeleteProfile(_command.Profile);
        }
    }
}
