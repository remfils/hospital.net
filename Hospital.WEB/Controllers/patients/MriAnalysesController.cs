using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers.patients
{
    [Route("patients")]
    public class MriAnalysesController : ControllerBase
    {
        [HttpDelete("{id}/mri_destroy")]
        public IActionResult RemoveMRI([FromQuery]int id)
        {
            // TODO: implement RemoveMRI
            throw new Exception();
        }

        [HttpGet("{id}/mri")]
        public IActionResult GetMRI([FromQuery]int id)
        {
            // TODO: implement GetMRI
            throw new Exception();
        }

        [HttpPost("{id}/mri_update")]
        public IActionResult UpdateMRI([FromQuery]int id)
        {
            // TODO: implement UpdateMRI
            throw new Exception();
        }

    }
}
