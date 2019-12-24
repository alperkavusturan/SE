using System;
using System.Collections.Generic;
using System.Text;
using TrackService.Business.Abstract;
using TrackService.Data.Models;
using TrackService.Domain.Commands.Command;

namespace TrackService.Domain.Commands.Handler
{
    public class EditTrackCommandHandler : ICommandHandler<EditTrackCommand, Track>
    {
        readonly ITrackService _service;
        readonly EditTrackCommand _command;

        public EditTrackCommandHandler(ITrackService service, EditTrackCommand command)
        {
            _service = service;
            _command = command;
        }

        public Track Execute()
        {
            return _service.EditTrack(_command.Track);
        }
    }
}
