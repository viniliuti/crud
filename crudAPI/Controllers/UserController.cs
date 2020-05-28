using System;
using System.Threading.Tasks;
using Abstractions.Services;
using Microsoft.AspNetCore.Mvc;

namespace crudAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;
        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpGet]
        public async Task<int> Get()
        {
            return await _userServices.Get();
        }

        [HttpGet]
        public async Task<string> Get([FromBody]string filter)
        {
            return await _userServices.Get(filter);
        }
    }
}