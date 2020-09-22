using MediatR;

namespace DomainDrivenDesignHelper.Domain
{
    public interface IDomainEventHandler<in TDe> 
        : INotificationHandler<TDe> where TDe : INotification
    {
    }
}
