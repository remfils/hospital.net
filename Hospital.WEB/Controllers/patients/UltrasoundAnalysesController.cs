using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers.patients
{
    [Route("patients")]
    public class UltrasoundAnalysesController : ControllerBase
    {
        [HttpDelete("{id}/ultrasound_destroy")]
        public IActionResult RemoveUltrasound([FromQuery] int id)
        {
            // TODO: implement RemoveUltrasound
            throw new Exception();
        }

        [HttpGet("{id}/ultrasound")]
        public IActionResult GetUltrasound([FromQuery] int id)
        {
            // TODO: implement GetUltrasound
            throw new Exception();
        }

        [HttpGet("{id}/ultrasound_edit")]
        public IActionResult EditUltrasound([FromQuery] int id)
        {
            // TODO: implement EditUltrasound
            throw new Exception();
        }

        [HttpGet("{id}/ultrasound_create")]
        public IActionResult CreateUltrasound([FromQuery] int id)
        {
            // TODO: implement CreateUltrasound
            throw new Exception();
        }

        [HttpPatch("{id}/ultrasound_update")]
        public IActionResult UpdateUltrasound([FromQuery] int id)
        {
            // TODO: implement UpdateUltrasound
            throw new Exception();
        }

    }
}
