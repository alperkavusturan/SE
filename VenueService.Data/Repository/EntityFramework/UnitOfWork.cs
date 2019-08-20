namespace VenueService.Data.Repository.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly EFDbContext _context;
        IVenueRepository _VenueRepository;
        IVenueTypeRepository _VenueTypeRepository;

        public UnitOfWork(EFDbContext context)
        {
            _context = context;
        }

        public IVenueRepository VenueRepository => _VenueRepository = _VenueRepository ?? new VenueRepository(_context);

        public IVenueTypeRepository VenueTypeRepository => _VenueTypeRepository = _VenueTypeRepository  ?? new VenueTypeRepository(_context);

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
