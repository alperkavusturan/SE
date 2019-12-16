using System;
using System.Collections.Generic;
using System.Text;

namespace TrackService.Data.Repository
{
    public interface IUnitOfWork
    {
        ITrackRepository TrackRepository { get; }


        void Save();
    }
}
