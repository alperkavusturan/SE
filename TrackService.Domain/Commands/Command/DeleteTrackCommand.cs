using System;
using System.Collections.Generic;
using System.Text;
using TrackService.Data.Models;

namespace TrackService.Domain.Commands.Command
{
    public class DeleteTrackCommand : ICommand<bool>
    {
        public Track Track { get; private set; }

        public DeleteTrackCommand(Track item)
        {
            Track = item;
        }
    }
}
