using System;
using System.Collections.Generic;
using System.Text;
using TrackService.Business.Abstract;
using TrackService.Data.Models;
using TrackService.Domain.Commands.Command;
using TrackService.Domain.Commands.Handler;

namespace TrackService.Domain.Commands
{
    public class TrackCommandHandlerFactory
    {
        readonly ITrackService _service;

        public TrackCommandHandlerFactory(ITrackService service)
        {
            _service = service;
        }

        public ICommandHandler<CreateTrackCommand, int> Build(CreateTrackCommand command)
        {
            return new CreateTrackCommandHandler(_service, command);
        }

        public ICommandHandler<EditTrackCommand, Track> Build(EditTrackCommand command)
        {
            return new EditTrackCommandHandler(_service, command);
        }

        public ICommandHandler<DeleteTrackCommand, bool> Build(DeleteTrackCommand command)
        {
            return new DeleteTrackCommandHandler(_service, command);
        }

    }
}
