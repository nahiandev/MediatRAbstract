using MediatRAbstract.Abstractions.Messaging;

namespace MediatRAbstract.ExampleUsage_Followers.StartFollowing
{
    public sealed record StartFollowingCommand(Guid UserId, Guid FollowedID) : ICommand;
}
