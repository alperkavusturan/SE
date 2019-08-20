namespace ArtistService.Data.Repository
{
    public interface IUnitOfWork
    {
        IArtistRepository ArtistRepository { get; }
        IArtistTypeRepository ArtistTypeRepository { get; }

        void Save();
    }
}
