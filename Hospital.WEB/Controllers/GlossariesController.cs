using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers
{
    [Route("glossaries")]
    public class GlossariesController : ControllerBase
    {

        [HttpGet("")]
        public IActionResult Index()
        {
            // TODO: implement Index
            throw new Exception();
        }

        [HttpDelete("values/{id}")]
        public IActionResult DeleteValue([FromQuery] int id)
        {
            // TODO: implement DeleteValue
            throw new Exception();
        }

        [HttpGet("{id}")]
        public IActionResult Get()
        {
            // TODO: implement Get
            throw new Exception();
        }

        [HttpPost("values")]
        public IActionResult AddValue()
        {
            // TODO: implement AddValue
            throw new Exception();
        }
        
    }
}
