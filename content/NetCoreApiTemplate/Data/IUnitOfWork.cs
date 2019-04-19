using System.Threading.Tasks;

namespace NetCoreApiTemplate.Data
{
    public interface IUnitOfWork
    {
        void Save();
        Task SaveAsync();
    }
}