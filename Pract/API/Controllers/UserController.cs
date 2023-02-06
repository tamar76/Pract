using Microsoft.AspNetCore.Mvc;
using Pract.common.DTO_s;
using Pract.Repository.Entities;
using Pract.Services;

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
        // GET: api/<ValuesController>
       
        [HttpGet]
        public async Task<List<UserDTO>> Get()
        {
            return await _User.GetAllAsync();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<UserDTO> Get(int id)
        {
            return await _User.GetByIdAsync(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<UserDTO> Post([FromBody] UserDTO value)
        {
            return await _User.AddAsync(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut]
        public async Task<UserDTO> Put([FromBody] UserDTO value)
        {
            return await _User.UpdateAsync(value);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _User.DeleteAsync(id);
        }
    }
}
