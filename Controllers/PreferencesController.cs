using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SkipTheDishes.Controllers
{
    [Route("api/[controller]")]
    public class PreferencesController : Controller
    {
        // GET api/preferences
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "pref1", "value2" };
        }

        // GET api/preferences/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/preferences
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/preferences/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/preferences/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
