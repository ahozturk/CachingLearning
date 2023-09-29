using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InMemoryCaching.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpGet("[action]/{name}")]
        public void Set(string name)
        {
            throw new NotImplementedException();
        }

        [HttpGet("[action]")]
        public string Get()
        {
            throw new NotImplementedException();
        }
    }
}
