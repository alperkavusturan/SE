namespace VenueService.Data.Repository
{
    public interface IUnitOfWork
    {
        IVenueRepository VenueRepository { get; }
        IVenueTypeRepository VenueTypeRepository { get; }

        void Save();
    }
}
