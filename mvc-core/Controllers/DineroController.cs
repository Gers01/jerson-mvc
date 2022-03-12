using Microsoft.AspNetCore.Mvc;
using mvc_core.Data;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mvc_core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DineroController : ControllerBase
    {
        private readonly MyDbContext _context;

        public DineroController(MyDbContext context)
        {
            _context = context;
        }

         // GET: api/<DineroController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Value1", "value2" };
        }

        // GET api/<DineroController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DineroController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DineroController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DineroController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
