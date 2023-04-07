using System.Threading.Tasks;
namespace AuthServer.Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task CommitAsync(); //SavaChanges();
        void Commit();
    }
}
