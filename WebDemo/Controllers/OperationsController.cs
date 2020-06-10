using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebDemo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OperationsController : ControllerBase
    {
        // GET: api/<OperationsController>
        [HttpGet]
        public double GetSum(int a, int b,int c,int d)
        {
            return a + b + c + d;
        }

        [HttpGet]
        public double GetProduct(int a, int b, int c)
        {
            return a * b * c;
        }

        [HttpGet]

        public double GetSubtraction(int a,int b)
        {
            return a - b;
        }
        // GET api/<OperationsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OperationsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<OperationsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OperationsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
