using MediatRAbstract.External_References;

namespace MediatRAbstract.Repository
{
    public interface ICrudRepository
    {
        Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
