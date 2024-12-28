using MediatRAbstract.External_References;

namespace MediatRAbstract.Abstractions.Followers.StartFollowing
{
    public static class UserErrors
    {
        public static Error NotFound(Guid userId) => new Error("User Not Found", $"User with the id {userId} was not found");

       
    }
}
