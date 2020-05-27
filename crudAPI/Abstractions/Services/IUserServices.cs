using System.Threading.Tasks;

namespace Abstractions.Services
{
    public interface IUserServices
    {
        public Task<int> Get();
    }
}