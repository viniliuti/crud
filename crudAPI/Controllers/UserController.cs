using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace crudAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public async Task<int> Get()
        {
            await Task.Delay(1);

            return new Random().Next();
        }
    }
}