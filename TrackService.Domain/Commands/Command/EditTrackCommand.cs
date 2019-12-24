using System;
using System.Collections.Generic;
using System.Text;
using TrackService.Data.Models;

namespace TrackService.Domain.Commands.Command
{
    public class EditTrackCommand : ICommand<Track>
    {
        public Track Track { get; private set; }

        public EditTrackCommand(Track item)
        {
            Track = item;
        }
    }
}
