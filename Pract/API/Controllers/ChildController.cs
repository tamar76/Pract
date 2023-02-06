using Microsoft.AspNetCore.Mvc;
using Pract.common.DTO_s;
using Pract.Repository.Entities;
using Pract.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController : ControllerBase
    {
        private readonly IService<ChildDTO> _Child;
        public ChildController(IService<ChildDTO> Child)
        {
            _Child = Child;
        }
        // GET: api/<ChildController>
        [HttpGet]
        public async Task<List<ChildDTO>> Get()
        {
            return await _Child.GetAllAsync();
        }

        // GET api/<ChildController>/5
        [HttpGet("{id}")]
        public async Task<ChildDTO> Get(int id)
        {
            return await _Child.GetByIdAsync(id);
        }

        // POST api/<ChildController>
        [HttpPost]
        public async Task<ChildDTO> Post([FromBody] ChildDTO value)
        {
            return await _Child.AddAsync(value);
        }

        // PUT api/<ChildController>/5/
        [HttpPut]
        public async Task<ChildDTO> Put([FromBody] ChildDTO value)
        {
            return await _Child.UpdateAsync(value);
        }

        // DELETE api/<ChildController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _Child.DeleteAsync(id);
        }
    }
}
