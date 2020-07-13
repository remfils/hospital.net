using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers.patients
{
    [Route("patients")]
    public class TemperatureController : ControllerBase
    {
        [HttpDelete("{id}/temperature")]
        public IActionResult RemoveTemperature([FromQuery] int id)
        {
            // TODO: implement RemoveTemperature
            throw new Exception();
        }

        [HttpPost("{id}/temperature/create")]
        public IActionResult CreateTemperature([FromQuery] int id)
        {
            // TODO: implement CreateTemperature
            throw new Exception();
        }

    }
}
