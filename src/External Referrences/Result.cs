namespace MediatRAbstract.External_References
{
    public class Result
    {
        public bool IsFailure { get; }

        public static Result Success()
        {
            throw new NotImplementedException();
        }
    }
    public class Result<TResponse>
    {
        public bool IsFailure { get; }

        public static Result Success()
        {
            throw new NotImplementedException();
        }
    }
}