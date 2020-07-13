using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers.patients
{
    [Route("patiens")]
    public class UrineController : ControllerBase
    {
        [HttpDelete("{id}/urine")]
        public IActionResult RemoveUrine([FromQuery] int id)
        {
            // TODO: implement RemoveUrine
            throw new Exception();
        }

        [HttpPost("{id}/urine/create")]
        public IActionResult CreateUrine([FromQuery] int id)
        {
            // TODO: implement CreateUrine
            throw new Exception();
        }

    }
}
