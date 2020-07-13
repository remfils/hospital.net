using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers.patients
{
    [Route("patients")]
    public class PreoperativeEpicrisisController : ControllerBase
    {
        [HttpDelete("{id}/destroy_preoperative_epicrisis")]
        public IActionResult RemovePreoperativeEpicrisis([FromQuery] int id)
        {
            // TODO: implement RemovePreoperativeEpicrisis
            throw new Exception();
        }

        [HttpGet("{id}/edit_preoperative_epicrisis")]
        public IActionResult EditPreoperativeEpicrisis([FromQuery] int id)
        {
            // TODO: implement EditPreoperativeEpicrisis
            throw new Exception();
        }

        [HttpGet("{id}/new_preoperative_epicrisis")]
        public IActionResult NewPreoperativeEpicrisi([FromQuery] int id)
        {
            // TODO: implement NewPreoperativeEpicrisi
            throw new Exception();
        }

        [HttpGet("{id}/preoperative_epicrisis")]
        public IActionResult GetPreoperativeEpicrisis([FromQuery] int id)
        {
            // TODO: implement GetPreoperativeEpicrisis
            throw new Exception();
        }

        // TODO: POST MAYBE?
        [HttpPatch("{id}/update_preoperative_epicrisis")]
        public IActionResult UpdatePreoperativeEpicrisis()
        {
            // TODO: implement UpdatePreoperativeEpicrisis
            throw new Exception();
        }

        [HttpPost("{id}/create_preoperative_epicrisis")]
        public IActionResult CreatePreoperativeEpicrisis([FromQuery] int id)
        {
            // TODO: implement CreatePreoperativeEpicrisis
            throw new Exception();
        }

    }
}
