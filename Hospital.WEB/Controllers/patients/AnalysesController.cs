using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers.patients
{
    [Route("patiens")]
    public class AnalysesController : ControllerBase
    {
        [HttpDelete("{id}/ct_destroy")]
        public IActionResult RemoveCT()
        {
            // TODO: implement RemoveCT
            throw new Exception();
        }

        [HttpDelete("{id}/mri_destroy")]
        public IActionResult RemoveMRI()
        {
            // TODO: implement RemoveCT
            throw new Exception();
        }

        [HttpDelete("{id}/ultrasound_destory")]
        public IActionResult RemoveUltrasound()
        {
            throw new Exception();
        }

        [HttpDelete("{id}/uroflow_destroy")]
        public IActionResult RemoveUroFlow()
        {
            // TODO: implement RemoveUroFlow
            throw new Exception();
        }

        [HttpDelete("{id}/xray_destroy")]
        public IActionResult RemoveXRay()
        {
            // TODO: implement RemoveXRay
            throw new Exception();
        }

        [HttpGet("{id}/bio_blood_testing")]
        public IActionResult GetBioBloodTesting()
        {
            // TODO: implement GetBioBloodTesting
            throw new Exception();
        }

        [HttpGet("{id}/bio_urine_testing")]
        public IActionResult GetBioUringeTesting()
        {
            // TODO: implement GetBioUringeTesting
            throw new Exception();
        }

        [HttpGet("{id}/blood_hepatite_testing")]
        public IActionResult GetBloodHepatiteTesting()
        {
            // TODO: implement GetBloodHepatiteTesting
            throw new Exception();
        }

        [HttpGet("{id}/blood_testing")]
        public IActionResult GetBloodTesting([FromQuery] int id)
        {
            // TODO: implement GetBloodTesting
            throw new Exception();
        }

        [HttpGet("{id}/blood_type_testing")]
        public IActionResult GetBloodTypeTesting([FromQuery] int id)
        {
            // TODO: implement GetBloodTypeTesting
            throw new Exception();
        }

        [HttpGet("{id}/coagulogram_testing")]
        public IActionResult GetCoagulogramTesting([FromQuery] int id)
        {
            // TODO: implement GetCoagulogramTesting
            throw new Exception();
        }

        [HttpGet("{id}/concrement_testing")]
        public IActionResult GetConcrementTesting([FromQuery] int id)
        {
            // TODO: implement GetConcrementTesting
            throw new Exception();
        }

        [HttpGet("{id}/ct")]
        public IActionResult GetCT([FromQuery] int id)
        {
            // TODO: implement GetCT
            throw new Exception();
        }

        [HttpGet("{id}/cytology")]
        public IActionResult GetCytology([FromQuery] int id)
        {
            // TODO: implement GetCytology
            throw new Exception();
        }

        [HttpGet("{id}/hiv_testing")]
        public IActionResult GetHIVTesting([FromQuery] int id)
        {
            // TODO: implement GetHIVTesting
            throw new Exception();
        }

        [HttpGet("{id}/hormones_testing")]
        public IActionResult GetHormonesTesting([FromQuery] int id)
        {
            // TODO: implement GetHormonesTesting
            throw new Exception();
        }

        [HttpGet("{id}/mri")]
        public IActionResult GetMRI([FromQuery] int id)
        {
            // TODO: implement GetMRI
            throw new Exception();
        }

        [HttpGet("{id}/psa_testing")]
        public IActionResult GetPSATesting([FromQuery] int id)
        {
            // TODO: implement GetPSATesting
            throw new Exception();
        }

        [HttpGet("{id}/syphilis_testing")]
        public IActionResult GetSyphilisTesting([FromQuery] int id)
        {
            // TODO: implement GetSyphilisTesting
            throw new Exception();
        }

        [HttpGet("{id}/ultrasound")]
        public IActionResult GetUltrasound([FromQuery] int id)
        {
            // TODO: implement GetUltrasound
            throw new Exception();
        }

        // TODO: possible fix

        [HttpGet("/ultrasound_edit")]
        public IActionResult GetUltrasoundEdit([FromQuery] int id)
        {
            // TODO: implement GetUltrasoundEdit
            throw new Exception();
        }

        [HttpGet("{id}/ultrasound_new")]
        public IActionResult GetUltrasoundNew([FromQuery] int id)
        {
            // TODO: implement GetUltrasoundNew
            throw new Exception();
        }

        [HttpGet("{id}/urine_testing")]
        public IActionResult GetUrineTesting([FromQuery] int id)
        {
            // TODO: implement GetUrineTesting
            throw new Exception();
        }

        [HttpGet("{id}/urine_testing_inoculation")]
        public IActionResult GetUrineTestingInoculation([FromQuery] int id)
        {
            // TODO: implement GetUrineTestingInoculation
            throw new Exception();
        }

        // TODO: what?

        [HttpGet("/urine_testing_nechiporenko")]
        public IActionResult GetUrineTestingNechiporenko([FromQuery] int id)
        {
            // TODO: implement GetUrineTestingNechiporenko
            throw new Exception();
        }

        [HttpGet("{id}/uroflow")]
        public IActionResult GetUrloflow([FromQuery] int id)
        {
            // TODO: implement GetUrloflow
            throw new Exception();
        }

        [HttpGet("{id}/xray")]
        public IActionResult GetXray([FromQuery] int id)
        {
            // TODO: implement GetXray
            throw new Exception();
        }

        // TODO: possible post?

        [HttpPatch("{id}/ultrasound_update")]
        public IActionResult UpdateUltrasound([FromQuery] int id)
        {
            // TODO: implement UpdateUltrasound
            throw new Exception();
        }

        [HttpPost("{id}/ct_update")]
        public IActionResult UpdateCT([FromQuery] int id)
        {
            // TODO: implement UpdateCT
            throw new Exception();
        }

        [HttpPost("{id}/mri_update")]
        public IActionResult UpdateMRI([FromQuery] int id)
        {
            // TODO: implement UpdateMRI
            throw new Exception();
        }

        [HttpPost("{id}/ultrasound_create")]
        public IActionResult CreateUltrasound([FromQuery] int id)
        {
            // TODO: implement CreateUltrasound
            throw new Exception();
        }

        [HttpPost("{id}/update_analyses")]
        public IActionResult UpdateAnalyses([FromQuery] int id)
        {
            // TODO: implement UpdateAnalyses
            throw new Exception();
        }

        [HttpPost("{id}/uroflow_update")]
        public IActionResult UpdateUroFlow([FromQuery] int id)
        {
            // TODO: implement UpdateUroFlow
            throw new Exception();
        }

        [HttpPost("{id}/xray_update")]
        public IActionResult UpdateXRay([FromQuery] int id)
        {
            // TODO: implement UpdateXRay
            throw new Exception();
        }
    }
}
