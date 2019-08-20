namespace VenueService.Domain.Commands
{
    public interface ICommand<out TResult>
    {
    }

    public interface ICommandHandler<in TCommand, out TResult> where TCommand : ICommand<TResult>
    {
        TResult Execute();
    }
}
