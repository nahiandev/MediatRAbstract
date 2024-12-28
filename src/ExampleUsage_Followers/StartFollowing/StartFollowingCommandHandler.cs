using MediatRAbstract.Abstractions.Messaging;
using MediatRAbstract.External_References;
using MediatRAbstract.Repository;
using MediatRAbstract.Service;
using MediatRAbstract.Unit;

namespace MediatRAbstract.ExampleUsage_Followers.StartFollowing
{
    public sealed class StartFollowingCommandHandler : ICommandHandler<StartFollowingCommand>
    {
        private readonly ICrudRepository _repository;
        private readonly ICrudService _service;
        private readonly IUnitOfWork _unit;

        public StartFollowingCommandHandler(ICrudRepository repository, ICrudService service, IUnitOfWork unit)
        {
            _repository = repository;
            _service = service;
            _unit = unit;
        }
        public async Task<Result> Handle(StartFollowingCommand command, CancellationToken cancellationToken)
        {
            User? user = await _repository.GetByIdAsync(command.UserId, cancellationToken);

            if (user is null)
            {
                // User not found
            }

            User? followed = await _repository.GetByIdAsync(command.FollowedID, cancellationToken);

            if (followed is null)
            {
                // Followed user not found
            }

            Result? result = await _service.StartFollowingAsync(user, followed, cancellationToken);

            if (result.IsFailure)
            {
                //  Handle failure
            }

            await _unit.SaveChangesAsync(cancellationToken);

            return Result.Success();
        }
    }
}
