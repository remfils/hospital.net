using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers.patients
{
    [Route("patients")]
    public class UroflowAnalysesController : ControllerBase
    {
        [HttpDelete("{id}/uroflow_destroy")]
        public IActionResult RemoveUroflow([FromQuery] int id)
        {
            // TODO: implement RemoveUroflow
            throw new Exception();
        }

        [HttpGet("{id}/uroflow")]
        public IActionResult GetUroflow([FromQuery] int id)
        {
            // TODO: implement GetUroflow
            throw new Exception();
        }

        [HttpPost("{id}/uroflow_update")]
        public IActionResult UpdateUroflow([FromQuery] int id)
        {
            // TODO: implement UpdateUroflow
            throw new Exception();
        }

    }
}
