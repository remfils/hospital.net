using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers.patients
{
    [Route("patients")]
    public class ConsultationsController : ControllerBase
    {
        [HttpDelete("{id}/destroy_consultations")]
        public IActionResult RemoveConsultations([FromQuery]int id)
        {
            // TODO: implement RemoveConsultations
            throw new Exception();
        }

        [HttpGet("{id}/consultations")]
        public IActionResult GetConsultations([FromQuery]int id)
        {
            // TODO: implement GetConsultations
            throw new Exception();
        }

        // TODO: duplicate?

        [HttpGet("{id}/edit_consultations")]
        public IActionResult EditConsultations([FromQuery]int id)
        {
            // TODO: implement EditConsultations
            throw new Exception();
        }

        [HttpGet("{id}/new_consultations")]
        public IActionResult NewConsultations([FromQuery]int id)
        {
            // TODO: implement NewConsultations
            throw new Exception();
        }

        // TODO: post maybe?

        [HttpPatch("{id}/update_consultations")]
        public IActionResult UpdateConsultations([FromQuery]int id)
        {
            // TODO: implement UpdateConsultations
            
            throw new Exception();
        }

        [HttpPost("{id}/create_consultations")]
        public IActionResult CreateConsultations([FromQuery]int id)
        {
            // TODO: implement CreateConsultations
            
            throw new Exception();
        }



    }
}
