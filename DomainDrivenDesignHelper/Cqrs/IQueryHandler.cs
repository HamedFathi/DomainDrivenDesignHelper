using MediatR;

namespace DomainDrivenDesignHelper.Cqrs
{
    public interface IQueryHandler<TQuery, TResult> : IRequestHandler<TQuery, TResult>
        where TQuery : IQuery<TResult>
    {
    }
}