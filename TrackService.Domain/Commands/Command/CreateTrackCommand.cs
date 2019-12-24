using System;
using System.Collections.Generic;
using System.Text;
using TrackService.Data.Models;

namespace TrackService.Domain.Commands.Command
{
    public class CreateTrackCommand : ICommand<int>
    {
        public Track Track { get; private set; }

        public CreateTrackCommand(Track item)
        {
            Track = item;
        }
    }
}
