namespace EventService.Domain.Queries
{
    public interface IQuery<out TResponse>
    {
    }

    public interface IQueryHandler<in TQuery, out TResponse> where TQuery : IQuery<TResponse>
    {
        TResponse Get();
    }
}
