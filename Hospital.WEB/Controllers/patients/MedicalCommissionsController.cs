using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers.patients
{
    [Route("patients")]
    public class MedicalCommissionsController : ControllerBase
    {
        [HttpDelete("{id}/destory_medical_commission")]
        public IActionResult RemoveMedicalCommision([FromQuery]int id)
        {
            // TODO: implement RemoveMedicalCommision
            throw new Exception();
        }

        [HttpGet("{id}/edit_medical_commission")]
        public IActionResult EditMedicalCommission([FromQuery]int id)
        {
            // TODO: implement EditMedicalCommission
            throw new Exception();
        }

        [HttpGet("{id}/medical_commission")]
        public IActionResult GetMedicalComittion([FromQuery]int id)
        {
            // TODO: implement GetMedicalComittion
            throw new Exception();
        }

        [HttpGet("{id}/new_medical_commission")]
        public IActionResult NewMedicalCommission([FromQuery]int id)
        {
            // TODO: implement NewMedicalCommission
            throw new Exception();
        }

        // TODO: post maybe?

        
        [HttpPatch("{id}/update_medical_commission")]
        public IActionResult UpdateMedicalCommission([FromQuery]int id)
        {
            // TODO: implement UpdateMedicalCommission
            throw new Exception();
        }

        [HttpPost("{id}/create_medical_commission")]
        public IActionResult CreateMedicalCommission([FromQuery]int id)
        {
            // TODO: implement CreateMedicalCommission
            throw new Exception();
        }

        
    }
}
