using Microsoft.AspNetCore.Mvc;
using RedisDistributedCaching.Services;

namespace RedisDistributedCaching.Controllers
{
    public class RedisController : Controller
    {
        [HttpGet("[action]/{key}/{value}")]
        public async Task<IActionResult> SetValue(string key, string value)
        {
            var redisMaster = await RedisService.GetRedisMasterDatabase();
            await redisMaster.StringSetAsync(key, value);
            return Ok();
        }

        [HttpGet("[action]/{key}")]
        public async Task<IActionResult> GetValue(string key)
        {
            var redisMaster = await RedisService.GetRedisMasterDatabase();
            var responseValue = await redisMaster.StringGetAsync(key);
            return Ok(responseValue.ToString());
        }
    }
}
