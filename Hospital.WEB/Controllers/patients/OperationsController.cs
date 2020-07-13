using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers.patients
{
    [Route("patients")]
    public class OperationsController : ControllerBase
    {
        [HttpDelete("{id}/destroy_operations")]
        public IActionResult RemoveOperations([FromQuery]int id)
        {
            // TODO: implement RemoveOperations
            throw new Exception();
        }

        [HttpGet("{id}/edit_operations")]
        public IActionResult EditOperations([FromQuery]int id)
        {
            // TODO: implement EditOperations
            throw new Exception();
        }

        [HttpGet("{id}/new_operations")]
        public IActionResult NewOperations([FromQuery]int id)
        {
            // TODO: implement NewOperations
            throw new Exception();
        }

        [HttpGet("{id}/operations")]
        public IActionResult GetOperations([FromQuery]int id)
        {
            // TODO: implement GetOperations
            throw new Exception();
        }

        [HttpPatch("{id}/update_operations")]
        public IActionResult UpdateOperations([FromQuery]int id)
        {
            // TODO: implement UpdateOperations
            throw new Exception();
        }

        [HttpPost("{id}/create_operations")]
        public IActionResult CreateOperations([FromQuery]int id)
        {
            // TODO: implement CreateOperations
            throw new Exception();
        }
    }
}
