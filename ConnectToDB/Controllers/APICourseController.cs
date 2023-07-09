using ConnectToDB.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ConnectToDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APICourseController : ControllerBase
    {
        ApplicationDbContext _dbContext;

        public APICourseController(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        // GET: api/<APICourseController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<APICourseController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<APICourseController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<APICourseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<APICourseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
