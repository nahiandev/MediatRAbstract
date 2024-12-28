using MediatRAbstract.External_References;

namespace MediatRAbstract.Service
{
    public interface ICrudService
    {
        Task<Result> StartFollowingAsync(User user, User followed, CancellationToken cancellationToken);
    }
}
