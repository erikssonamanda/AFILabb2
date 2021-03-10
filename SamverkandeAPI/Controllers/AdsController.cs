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
    public class AdsController : ControllerBase
    {
        // GET: api/<AdsController>
        [HttpGet]
        public string Get()
        {
            List<Ads> annonser = new List<Ads>();
            SamverkandeMetoder sm = new SamverkandeMetoder();
            annonser = sm.GetAllaAds(out string errormsg);
            string s = JsonConvert.SerializeObject(annonser);
            return s;
        }

        // GET api/<AdsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            Ads annons = new Ads();
            SamverkandeMetoder sm = new SamverkandeMetoder();
            annons = sm.GetAd(id, out string errormsg);
            string s = JsonConvert.SerializeObject(annons);
            return s; 
        }

        // POST api/<AdsController>
        [HttpPost]
        public StatusCodeResult Post([FromBody] Ads ad)
        {
            SamverkandeMetoder sm = new SamverkandeMetoder();
            int i = sm.PostAd(ad, out string errormsg);
            Console.WriteLine(errormsg);
            return Ok();
        }

        // PUT api/<AdsController>/5
        [HttpPut("{id}")]
        public StatusCodeResult Put(int id, [FromBody] Ads ad)
        {
            SamverkandeMetoder sm = new SamverkandeMetoder();
            int i = sm.PutAd(id, ad, out string errormsg); 
            if(i == 0)
            {
                return BadRequest();
            }
            else
            {
                return Ok();
            }
        }

        // DELETE api/<AdsController>/5
        [HttpDelete("{id}")]
        public StatusCodeResult Delete(int id)
        {
            SamverkandeMetoder sm = new SamverkandeMetoder();
            int i = sm.DeleteAd(id, out string errormsg);
            Console.WriteLine(errormsg); 
            if(i == 0)
            {
                return BadRequest();
            }
            else
            {
                return Ok(); 
            }
        }
    }
}
