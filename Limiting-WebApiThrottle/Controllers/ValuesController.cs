using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiThrottle;

namespace Limiting_WebApiThrottle.Controllers
{
    [EnableThrottling]
    public class ValuesController : ApiController
    {
        //[EnableThrottling(PerSecond = 1, PerMinute = 1, PerHour = 100)]
        // GET api/values
        [HttpGet]
        [Route("api/meysam")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
