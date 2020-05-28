using System.Threading.Tasks;

namespace Abstractions.Services
{
    public interface IUserServices
    {
        Task<int> Get();
        Task<string> Get(string filter);
    }
}