namespace CleanArchitecture.Shared.Queries
{
    public interface IQueryDispatcher
    {
        Task<TResult> QueryAsync<TResult>(IQuery<TResult> query);
    }
}