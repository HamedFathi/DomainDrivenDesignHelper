using MediatR;

namespace DomainDrivenDesignHelper.Domain
{
    public interface IDomainEventHandler<in TDomainEvent> 
        : INotificationHandler<TDomainEvent> where TDomainEvent : INotification
    {
    }
}
