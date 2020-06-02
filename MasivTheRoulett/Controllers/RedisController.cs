using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyCaching.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MasivTheRoulett.Controllers
{
    [Route("/Redis")]
    [ApiController]
    public class RedisController : ControllerBase
    {
        private IEasyCachingProvider cachingProvider;
        private IEasyCachingProviderFactory cachingProviderFactory;

        public RedisController(IEasyCachingProviderFactory cachingProviderFactory)
        {
            this.cachingProviderFactory = cachingProviderFactory;
            this.cachingProvider = this.cachingProviderFactory.GetCachingProvider("redis1");
        }

        [HttpGet("Set")]
        public IActionResult setItem()
        {
            this.cachingProvider.Set("MyKey", "Brayan Canon", TimeSpan.FromDays(100));


            return Ok();
        }

        [HttpGet("Get")]
        public IActionResult getItem()
        {
            var item = this.cachingProvider.Get<String>("MyKey");

            return Ok(item);
        }
    }
}
