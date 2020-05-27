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
    }
}