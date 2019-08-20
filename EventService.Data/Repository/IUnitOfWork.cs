namespace EventService.Data.Repository
{
    public interface IUnitOfWork
    {
        IEventRepository EventRepository { get; }
        IEventTypeRepository EventTypeRepository { get; }

        void Save();
    }
}
