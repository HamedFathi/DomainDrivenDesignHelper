using MediatR;

namespace DomainDrivenDesignHelper.Cqrs
{
    public interface IQuery<out TResult> : IRequest<TResult>
    {
    }
}