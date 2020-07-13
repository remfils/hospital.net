using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers.patients
{
    [Route("patients")]
    public class XrayAnalysesController : ControllerBase
    {
        [HttpDelete("{id}/xray_destroy")]
        public IActionResult RemoveXray([FromQuery] int id)
        {
            // TODO: implement RemoveXray
            throw new Exception();
        }

        [HttpGet("{id}/xray")]
        public IActionResult GetXray([FromQuery] int id)
        {
            // TODO: implement GetXray
            throw new Exception();
        }

        [HttpPost("{id}/xray_update")]
        public IActionResult UpdateXray([FromQuery] int id)
        {
            // TODO: implement UpdateXray
            throw new Exception();
        }

    }
}
