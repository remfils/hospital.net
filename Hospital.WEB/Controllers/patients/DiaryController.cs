using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers.patients
{
    [Route("patients")]
    public class DiaryController : ControllerBase
    {
        [HttpDelete("{id}/destory_checkup_log")]
        public IActionResult RemoveCheckupLog([FromQuery]int id)
        {
            // TODO: implement RemoveCheckupLog
            throw new Exception();
        }

        [HttpGet("{id}/checkup_log")]
        public IActionResult GetCheckupLog([FromQuery]int id)
        {
            // TODO: implement GetCheckupLog
            throw new Exception();
        }

        [HttpGet("{id}/edit_checkup_log")]
        public IActionResult EditCheckupLog([FromQuery]int id)
        {
            // TODO: implement EditCheckupLog
            throw new Exception();
        }

        [HttpGet("{id}/new_checkup_log")]
        public IActionResult CreateCheckupLog([FromQuery]int id)
        {
            // TODO: implement CreateCheckupLog
            throw new Exception();
        }

        [HttpPatch("{id}/update_checkup_log")]
        public IActionResult UpdateCheckupLog([FromQuery]int id)
        {
            // TODO: implement UpdateCheckupLog
            throw new Exception();
        }

        [HttpPost("{id}/create_checkup_log")]
        public IActionResult CreateCheckupLog([FromQuery]int id)
        {
            // TODO: implement CreateCheckupLog
            throw new Exception();
        }

    }
}
