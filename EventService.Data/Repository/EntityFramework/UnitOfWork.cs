namespace EventService.Data.Repository.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly EFDbContext _context;
        IEventRepository _EventRepository;
        IEventTypeRepository _EventTypeRepository;

        public UnitOfWork(EFDbContext context)
        {
            _context = context;
        }

        public IEventRepository EventRepository => _EventRepository = _EventRepository ?? new EventRepository(_context);

        public IEventTypeRepository EventTypeRepository => _EventTypeRepository = _EventTypeRepository ?? new EventTypeRepository(_context);

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
