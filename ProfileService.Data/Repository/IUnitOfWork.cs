namespace ProfileService.Data.Repository
{
    public interface IUnitOfWork
    {
        IProfileRepository ProfileRepository { get; }
        IProfileTypeRepository ProfileTypeRepository { get; }

        void Save();
    }
}
