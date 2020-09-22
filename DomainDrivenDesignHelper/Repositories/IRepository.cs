using DomainDrivenDesignHelper.Domain;

namespace DomainDrivenDesignHelper.Repositories
{
    public interface IRepository<T> where T : class, IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
