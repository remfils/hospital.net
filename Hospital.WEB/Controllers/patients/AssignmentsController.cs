using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers.patients
{
    [Route("patients")]
    public class AssignmentsController : ControllerBase
    {
        [HttpGet("{id}/appointment_analyzes")]
        public IActionResult AppointmentAnalyzes([FromQuery]int id)
        {
            // TODO: implement AppointmentAnalyzes
            throw new Exception();
        }

        [HttpGet("{id}/appointment_sheet")]
        public IActionResult GetAppointmentSheet([FromQuery]int id)
        {
            // TODO: implement GetAppointmentSheet
            throw new Exception();
        }

        [HttpPost("{id}/appointment_analyzes")]
        public IActionResult UpdateAppointmentAnalyzes([FromQuery]int id)
        {
            // TODO: implement UpdateAppointmentAnalyzes
            throw new Exception();
        }

        [HttpPost("{id}/appointment_sheet")]
        public IActionResult UpdateAppointmentSheet([FromQuery]int id)
        {
            // TODO: implement UpdateAppointmentSheet
            throw new Exception();
        }

        [HttpPost("{id}/assignment_resolve")]
        public IActionResult ResolveAssigments([FromQuery]int id)
        {
            // TODO: implement ResolveAssigments
            throw new Exception();
        }
    }
}
