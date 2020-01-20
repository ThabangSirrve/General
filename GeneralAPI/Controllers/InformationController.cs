using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeneralAPI.Controllers
{
    [Authorize]
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class InformationController : ControllerBase
    {
        // GET: api/Information
        [HttpGet]
        [Route("GetInfromation")]
        public IEnumerable<string> Get()
        {
            string me = "Hello one and ";
            string usus = "hello 2";
            return new List<string>{ me, usus };
        }

        // POST: api/Information
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}