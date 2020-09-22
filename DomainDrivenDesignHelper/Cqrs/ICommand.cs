using MediatR;

namespace DomainDrivenDesignHelper.Cqrs
{
    public interface ICommand : ICommand<Unit>
    {
    }

    public interface ICommand<out TResult> : IRequest<TResult>
    {
    }
}
