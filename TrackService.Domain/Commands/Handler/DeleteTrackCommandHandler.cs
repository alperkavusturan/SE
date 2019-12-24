using System;
using System.Collections.Generic;
using System.Text;
using TrackService.Business.Abstract;
using TrackService.Domain.Commands.Command;

namespace TrackService.Domain.Commands.Handler
{
    public class DeleteTrackCommandHandler : ICommandHandler<DeleteTrackCommand, bool>
    {
        readonly ITrackService _service;
        readonly DeleteTrackCommand _command;

        public DeleteTrackCommandHandler(ITrackService service, DeleteTrackCommand command)
        {
            _service = service;
            _command = command;
        }
        public bool Execute()
        {
            return _service.DeleteTrack(_command.Track);
        }
    }
}
