using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SkipTheDishes.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        // GET api/login
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "pref1", "value2" };
        }

        // GET api/login/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/login
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/login/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/login/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
