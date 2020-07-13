using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers.patients
{
    [Route("events")]
    public class EventsController : ControllerBase
    {
        [HttpGet("index")]
        public IActionResult Index()
        {
            // TODO: implement Index
            throw new Exception();
        }

        [HttpGet("mine")]
        public IActionResult GetMine()
        {
            // TODO: implement GetMine
            
            throw new Exception();
        }

        [HttpGet("read")]
        public IActionResult ReadEvents()
        {
            // TODO: implement ReadEvents
            throw new Exception();
        }

        [HttpGet("read_all")]
        public IActionResult ReadAll()
        {
            // TODO: implement ReadAll
            throw new Exception();
        }

    }
}
