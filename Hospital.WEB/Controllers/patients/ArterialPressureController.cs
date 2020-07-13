using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers.patients
{
    [Route("patients")]
    public class ArterialPressureController : ControllerBase
    {
        [HttpDelete("{id}/arterial_pressure")]
        public IActionResult RemoveArterialPressure([FromQuery]int id)
        {
            // TODO: implement RemoveArterialPressure
            throw new Exception();
        }

        [HttpPost("{id}/arterial_pressure/create")]
        public IActionResult CreateArterialPressure([FromQuery]int id)
        {
            // TODO: implement CreateArterialPressure
            throw new Exception();
        }
    }
}
