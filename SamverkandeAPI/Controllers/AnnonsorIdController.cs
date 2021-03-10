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
    public class AnnonsorIdController : ControllerBase
    {
        // GET: api/<AnnonsorIdController>
        [HttpGet]
        public string Get()
        {
            Annonsorer annonsorId = new Annonsorer();
            SamverkandeMetoder sm = new SamverkandeMetoder();
            annonsorId = sm.GetAnnonsorId(out string errormsg);
            string s = JsonConvert.SerializeObject(annonsorId);
            return s; 
        }

        // GET api/<AnnonsorIdController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AnnonsorIdController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AnnonsorIdController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AnnonsorIdController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
