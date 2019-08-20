namespace ArtistService.Data.Repository.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly EFDbContext _context;
        IArtistRepository _ArtistRepository;
        IArtistTypeRepository _ArtistTypeRepository;

        public UnitOfWork(EFDbContext context)
        {
            _context = context;
        }

        public IArtistRepository ArtistRepository => _ArtistRepository = _ArtistRepository ?? new ArtistRepository(_context);

        public IArtistTypeRepository ArtistTypeRepository => _ArtistTypeRepository = _ArtistTypeRepository  ?? new ArtistTypeRepository(_context);

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
