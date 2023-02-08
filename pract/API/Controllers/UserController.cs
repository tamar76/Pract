using Microsoft.AspNetCore.Mvc;
using Pract.common.DTO_s;
//using Pract.Repository.Entities;
using Pract.Services;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IService<UserDTO> _User;
        public UserController(IService<UserDTO> User)
        {
            _User = User;
        }
      
       
    
       

        // POST api/<ValuesController>
        [HttpPost]
       
        public async Task<List<UserDTO>> Post([FromBody] List<UserDTO> value)
        {
            return await _User.Add(value);
        }

    }
}
