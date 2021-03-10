using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SamverkandeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SamverkandeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnonsorerController : ControllerBase
    {
        // GET: api/<AnnonsorerController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AnnonsorerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            Annonsorer annonsor = new Annonsorer();
            SamverkandeMetoder sm = new SamverkandeMetoder();
            annonsor = sm.GetAnnonsor(id, out string errormsg);
            string s = JsonConvert.SerializeObject(annonsor);
            return s;
        }

        // POST api/<AnnonsorerController>
        [HttpPost]
        public StatusCodeResult Post([FromBody] Annonsorer nyAnnonsor)
        {
            SamverkandeMetoder sm = new SamverkandeMetoder();
            int i = sm.PostAnnonsor(nyAnnonsor, out string errormsg);
            Console.WriteLine(errormsg);
            return Ok(); 
        }

        // PUT api/<AnnonsorerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AnnonsorerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
