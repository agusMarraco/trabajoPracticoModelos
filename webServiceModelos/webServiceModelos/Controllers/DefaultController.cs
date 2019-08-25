using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webServiceModelos.BLL;

namespace webServiceModelos.Controllers
{
    [Route("/")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public ActionResult<String> get()
        {
            return new JsonResult("HOLA MUNDO");
        }

        [HttpGet("/data")]
        public ActionResult<String> getData()
        {
            return new JsonResult(GenerateData.execute());
        }
    }
}