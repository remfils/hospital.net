using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers
{
    [Route("patiens")]
    public class PatientsController : ControllerBase
    {
        [HttpDelete("{id}")]
        public IActionResult Remove([FromQuery] int id)
        {
            // TODO: implement Remove
            throw new Exception();
        }

        [HttpGet("")]
        public IActionResult GetList()
        {
            // TODO: implement GetList
            throw new Exception();
        }

        [HttpGet("/blood_transfusion/edit")]
        public IActionResult EditBloodTransfusion()
        {
            // TODO: implement EditBloodTransfusion
            throw new Exception();
        }
        
        [HttpGet("edit_department_head")]
        public IActionResult EditDepartmentHead()
        {
            // TODO: implement EditDepartmentHead
            throw new Exception();
        }

        [HttpGet("/edit_discharge_checkup_log")]
        public IActionResult EditDischargeCheckupLog()
        {
            // TODO: implement EditDischargeCheckupLog
            throw new Exception();
        }

        [HttpGet("/edit_primary_info")]
        public IActionResult EditPrimaryInfo()
        {
            // TODO: implement EditPrimaryInfo
            throw new Exception();
        }

        [HttpGet("/epicrisis/edit")]
        public IActionResult EditEpicrisis()
        {
            // TODO: implement EditEpicrisis
            throw new Exception();
        }

        [HttpGet("/epicrisis_milestones")]
        public IActionResult GetEpicrisisMilestones()
        {
            // TODO: implement GetEpicrisisMilestones
            throw new Exception();
        }

        [HttpGet("/gradual_epicrisis/edit")]
        public IActionResult EditGradualEpicrisis()
        {
            // TODO: implement EditGradualEpicrisis
            throw new Exception();
        }

        [HttpGet("/medical_card_discharge")]
        public IActionResult GetMedicalCardDischarge()
        {
            // TODO: implement GetMedicalCardDischarge
            throw new Exception();
        }

        [HttpGet("/onco_consultation/edit")]
        public IActionResult EditOncoConsultation()
        {
            // TODO: implement EditOncoConsultation
            throw new Exception();
        }

        [HttpGet("/pathoanatomical_data")]
        public IActionResult GetPathoanatomicalData()
        {
            // TODO: implement GetPathoanatomicalData
            throw new Exception();
        }

        [HttpGet("/uzi")]
        public IActionResult GetUzi()
        {
            // TODO: implement GetUzi
            throw new Exception();
        }

        [HttpGet("/x_ray")]
        public IActionResult GetXray()
        {
            // TODO: implement GetXray
            throw new Exception();
        }

        [HttpGet("appointment_sheet_department")]
        public IActionResult GetAppointmentSheetDepartment()
        {
            // TODO: implement GetAppointmentSheetDepartment
            throw new Exception();
        }

        [HttpGet("assignments_by_date")]
        public IActionResult GetAssigmentsByDate()
        {
            // TODO: implement Test
            throw new Exception();
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            // TODO: implement Create
            throw new Exception();
        }

        // TODO: patch maybe?
        [HttpPatch("update")]
        public IActionResult Update()
        {
            // TODO: implement Update
            throw new Exception();
        }

        [HttpPost("create")]
        public IActionResult Create()
        {
            // TODO: implement Create
            throw new Exception();
        }
    }
}
