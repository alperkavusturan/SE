using System;
using System.Collections.Generic;
using System.Text;

namespace TicketingService.Domain.Queries
{
    public interface IQuery<out TResponse>
    {
    }

    public interface IQueryHandler<in TQuery, out TResponse> where TQuery : IQuery<TResponse>
    {
        TResponse Get();
    }
}
