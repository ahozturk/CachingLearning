﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace InMemoryCaching.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        readonly IMemoryCache _memoryCache;

        public ValuesController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        [HttpGet("[action]/{name}")]
        public void Set(string name)
        {
            _memoryCache.Set("name", name);
        }

        [HttpGet("[action]")]
        public string Get()
        {
            if (_memoryCache.TryGetValue<string>("name", out string name))
                return name.Substring(3);
            return "";
        }
    }
}
