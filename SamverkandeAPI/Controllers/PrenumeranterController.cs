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
    public class PrenumeranterController : ControllerBase
    {
        // GET: api/<PrenumeranterController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PrenumeranterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            Prenumeranter prenumerantId = new Prenumeranter();
            SamverkandeMetoder sm = new SamverkandeMetoder();
            prenumerantId = sm.GetPrenumerant(id, out string errormsg);
            string s = JsonConvert.SerializeObject(prenumerantId);
            return s; 
        }

        // POST api/<PrenumeranterController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PrenumeranterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PrenumeranterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
