using System.Threading;
using System.Threading.Tasks;

namespace DomainDrivenDesignHelper.Repositories
{
    public interface IUnitOfWork
    {
        Task<bool> CommitAsync(CancellationToken cancellationToken);
    }
}
