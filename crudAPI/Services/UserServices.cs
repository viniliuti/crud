using System;
using System.Threading.Tasks;
using Abstractions.Services;

namespace crudAPI.Services
{
    public class UserServices : IUserServices
    {
        public async Task<int> Get()
        {
            await Task.Delay(1);

            return new Random().Next();
        }

        public async Task<string> Get(string filter)
        {
            await Task.Delay(1);

            return "Oi bebe";
        }
    }
}