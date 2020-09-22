using System.Threading.Tasks;

namespace DomainDrivenDesignHelper.Domain
{
    public interface IDomainEventManager
    {
        Task Publish(IDomainEvent @event);
        Task Publish(params IDomainEvent[] events);
    }
}
