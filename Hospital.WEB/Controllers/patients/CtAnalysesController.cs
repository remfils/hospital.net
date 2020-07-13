using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers.patients
{
    [Route("patients")]
    public class CtAnalysesController : ControllerBase
    {
        [HttpDelete("{id}/ct_destroy")]
        public IActionResult RemoveCT([FromQuery]int id)
        {
            // TODO: implement RemoveCT
            throw new Exception();
        }

        [HttpGet("{id}/ct")]
        public IActionResult GetCT([FromQuery]int id)
        {
            // TODO: implement GetCT
            throw new Exception();
        }

        [HttpPost("{id}/ct_update")]
        public IActionResult UpdateCT([FromQuery]int id)
        {
            // TODO: implement UpdateCT
            throw new Exception();
        }
    }
}
