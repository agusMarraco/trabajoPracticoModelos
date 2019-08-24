using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace webServiceModelos.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<String> Get()
        {
            return  "BIENVENIDO A NUESTRO WEBSERVICE REST, PIDA LA POSICIÓN DE FIBONACCI Y SE LA GENERAMOS";
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return getFibonacciNumber(id).ToString();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


        public Double getFibonacciNumber(double position)
        {
            if(position < 3)
            {
                return 1;
            } else
            {
                return getFibonacciNumber(position - 2) + getFibonacciNumber(position - 1);
            }

        }

    }
}
