using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers
{
    [Route("calendar")]
    public class CalendarController : ControllerBase
    {
        [HttpGet()]
        public IActionResult Index()
        {
            // TODO: implement Index
            throw new Exception();
        }

        [HttpPost("create_event")]
        public IActionResult CreateEvent()
        {
            // TODO: implement CreateEvent
            throw new Exception();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEvent([FromQuery]int id)
        {
            // TODO: implement DeleteEvent
            throw new Exception();
        }

        [HttpPost("search")]
        public IActionResult Search()
        {
            // TODO: implement Search
            throw new Exception();
        }
    }
}
