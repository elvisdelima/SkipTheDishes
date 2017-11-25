using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SkipTheDishes.Data;
using SkipTheDishes.Domain;

namespace SkipTheDishes.Controllers
{
    [Route("api/[controller]")]
    public class TastesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public TastesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET api/tastes
        [HttpGet]
        public IEnumerable<Taste> Get() 
        {
            return _context.Tastes.ToList();
        }

        // GET api/tastes/5
        [HttpGet("{id}")]
        public Taste Get(int id)
        {
            return _context.Tastes.FirstOrDefault(x => x.Id == id);
        }

        // POST api/tastes
        [HttpPost]
        public IActionResult Post([FromBody]Taste value)
        {
            _context.Tastes.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        // PUT api/tastes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/tastes/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
