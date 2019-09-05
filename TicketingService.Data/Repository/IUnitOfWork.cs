using System;
using System.Collections.Generic;
using System.Text;

namespace TicketingService.Data.Repository
{
    public interface IUnitOfWork
    {
        ITicketingRepository TicketingRepository { get; }

        void Save();
    }
}
