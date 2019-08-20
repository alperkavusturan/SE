namespace ProfileService.Data.Repository.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly EFDbContext _context;
        IProfileRepository _profileRepository;
        IProfileTypeRepository _profileTypeRepository;

        public UnitOfWork(EFDbContext context)
        {
            _context = context;
        }

        public IProfileRepository ProfileRepository => _profileRepository = _profileRepository ?? new ProfileRepository(_context);

        public IProfileTypeRepository ProfileTypeRepository => _profileTypeRepository = _profileTypeRepository  ?? new ProfileTypeRepository(_context);

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
