using System;
using System.Collections.Generic;
using System.Text;
using TrackService.Business.Abstract;
using TrackService.Domain.Commands.Command;

namespace TrackService.Domain.Commands.Handler
{
    public class CreateTrackCommandHandler : ICommandHandler<CreateTrackCommand, int>
    {
        readonly ITrackService _service;
        readonly CreateTrackCommand _command;

        public CreateTrackCommandHandler(ITrackService service, CreateTrackCommand command)
        {
            _service = service;
            _command = command;
        }
        public int Execute()
        {
            return _service.CreateTrack(_command.Track);
        }
    }
}
