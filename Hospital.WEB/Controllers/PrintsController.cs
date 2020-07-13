using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers
{
    [Route("patients")]
    public class PrintsController : ControllerBase
    {

        [HttpGet("{id}/print/agreement")]
        public IActionResult PrintAgreement([FromQuery] int id)
        {
            // TODO: implement PrintAgreement
            throw new Exception();
        }

        [HttpGet("{id}/print/agreement_common")]
        public IActionResult PrintAgreementCommon([FromQuery] int id)
        {
            // TODO: implement PrintAgreementCommon
            throw new Exception();
        }

        [HttpGet("{id}/print/agreement_user_data")]
        public IActionResult PrintAgreementUserData([FromQuery] int id)
        {
            // TODO: implement PrintAgreementUserData
            throw new Exception();
        }

        [HttpGet("{id}/print/analysis")]
        public IActionResult PrintAnalysis([FromQuery] int id)
        {
            // TODO: implement PrintAnalysis
            throw new Exception();
        }

        [HttpGet("{id}/print/appointment_analyzes")]
        public IActionResult PrintAppointmentAnalyzes([FromQuery] int id)
        {
            // TODO: implement PrintAppointmentAnalyzes
            throw new Exception();
        }

        [HttpGet("{id}/print/appointment_sheet")]
        public IActionResult PrintAppointmentSheet([FromQuery] int id)
        {
            // TODO: implement PrintAppointmentSheet
            throw new Exception();
        }

        [HttpGet("{id}/print/blood_transfusion")]
        public IActionResult PrintBloodTransfusion([FromQuery] int id)
        {
            // TODO: implement PrintBloodTransfusion
            throw new Exception();
        }

        [HttpGet("{id}/print/checkup_log")]
        public IActionResult PrintCheckupLog([FromQuery] int id)
        {
            // TODO: implement PrintCheckupLog
            throw new Exception();
        }

        [HttpGet("{id}/print/consultation")]
        public IActionResult PrintConsultation([FromQuery] int id)
        {
            // TODO: implement PrintConsultation
            throw new Exception();
        }

        [HttpGet("{id}/print/cystoscopy")]
        public IActionResult PrintCystoscopy([FromQuery] int id)
        {
            // TODO: implement PrintCystoscopy
            throw new Exception();
        }

        [HttpGet("{id}/print/department_head")]
        public IActionResult PrintDepartmentHead([FromQuery] int id)
        {
            // TODO: implement PrintDepartmentHead
            throw new Exception();
        }

        [HttpGet("{id}/print/discharge_checkup_log")]
        public IActionResult PrintDischargeCheckupLog([FromQuery] int id)
        {
            // TODO: implement PrintDischargeCheckupLog
            throw new Exception();
        }

        [HttpGet("{id}/print/epicrisis")]
        public IActionResult PrintEpicrisis([FromQuery] int id)
        {
            // TODO: implement PrintEpicrisis
            throw new Exception();
        }

        [HttpGet("{id}/print/gradual_epicrisis")]
        public IActionResult PrintGradualEpicrisis([FromQuery] int id)
        {
            // TODO: implement PrintGradualEpicrisis
            throw new Exception();
        }

        [HttpGet("{id}/print/medical_card")]
        public IActionResult PrintMedicalCard([FromQuery] int id)
        {
            // TODO: implement PrintMedicalCard
            throw new Exception();
        }

        [HttpGet("{id}/print/medical_card_discharge")]
        public IActionResult PrintMedicalCardDischarge([FromQuery] int id)
        {
            // TODO: implement PrintMedicalCardDischarge
            throw new Exception();
        }

        [HttpGet("{id}/print/medical_commission")]
        public IActionResult PrintMedicalCommission([FromQuery] int id)
        {
            // TODO: implement PrintMedicalCommission
            throw new Exception();
        }

        [HttpGet("{id}/print/onco_consultation")]
        public IActionResult PrintOncoConsultation([FromQuery] int id)
        {
            // TODO: implement PrintOncoConsultation
            throw new Exception();
        }

        [HttpGet("{id}/print/operation")]
        public IActionResult PrintOperation([FromQuery] int id)
        {
            // TODO: implement PrintOperation
            throw new Exception();
        }

        [HttpGet("{id}/print/pathoanatomical_data")]
        public IActionResult PrintPathoanatomicalData([FromQuery] int id)
        {
            // TODO: implement PrintPathoanatomicalData
            throw new Exception();
        }

        [HttpGet("{id}/print/preoperative_epicrisis")]
        public IActionResult PrintPreoperativeEpicrisis([FromQuery] int id)
        {
            // TODO: implement PrintPreoperativeEpicrisis
            throw new Exception();
        }

        [HttpGet("{id}/print/primary_info")]
        public IActionResult PrintPrimaryInfo([FromQuery] int id)
        {
            // TODO: implement PrintPrimaryInfo
            throw new Exception();
        }

        [HttpGet("{id}/print/prostate_biopsy_card")]
        public IActionResult PrintProstateBiopsyCard([FromQuery] int id)
        {
            // TODO: implement PrintProstateBiopsyCard
            throw new Exception();
        }

        [HttpGet("{id}/print/qr_code")]
        public IActionResult PrintQrCode([FromQuery] int id)
        {
            // TODO: implement PrintQrCode
            throw new Exception();
        }

        [HttpGet("{id}/print/referral/bio_blood_testing")]
        public IActionResult PrintReferralBioBloodTesting([FromQuery] int id)
        {
            // TODO: implement PrintReferralBioBloodTesting
            throw new Exception();
        }

        [HttpGet("{id}/print/referral/bioall_blood_testing")]
        public IActionResult PrintReferralBioallBloodTesting([FromQuery] int id)
        {
            // TODO: implement PrintReferralBioallBloodTesting
            throw new Exception();
        }

        [HttpGet("{id}/print/referral/clinic_blood_testing")]
        public IActionResult PrintReferralClinicBloodTesting([FromQuery] int id)
        {
            // TODO: implement PrintReferralClinicBloodTesting
            throw new Exception();
        }

        [HttpGet("{id}/print/referral/cytology")]
        public IActionResult PrintReferralCytology([FromQuery] int id)
        {
            // TODO: implement PrintReferralCytology
            throw new Exception();
        }

        [HttpGet("{id}/print/referral/immuno_blood_testing")]
        public IActionResult PrintReferralImmunoBloodTesting([FromQuery] int id)
        {
            // TODO: implement PrintReferralImmunoBloodTesting
            throw new Exception();
        }

        [HttpGet("{id}/print/referral/immunohiv_blood_testing")]
        public IActionResult PrintReferralImmunohivBloodTesting([FromQuery] int id)
        {
            // TODO: implement PrintReferralImmunohivBloodTesting
            throw new Exception();
        }

        [HttpGet("{id}/print/referral/immunohuma_blood_testing")]
        public IActionResult PrintReferralImmunohumaBloodTesting([FromQuery] int id)
        {
            // TODO: implement PrintReferralImmunohumaBloodTesting
            throw new Exception();
        }

        [HttpGet("{id}/print/referral/urine_testing")]
        public IActionResult PrintReferralUrineTesting([FromQuery] int id)
        {
            // TODO: implement PrintReferralUrineTesting
            throw new Exception();
        }

        [HttpGet("{id}/print/referral/urine_testing_inoculation")]
        public IActionResult PrintReferralUrineTestingInoculation([FromQuery] int id)
        {
            // TODO: implement PrintReferralUrineTestingInoculation
            throw new Exception();
        }

        [HttpGet("{id}/print/referral/urine_testing_nechiporenko")]
        public IActionResult PrintReferralUrineTestingNechiporenko([FromQuery] int id)
        {
            // TODO: implement PrintReferralUrineTestingNechiporenko
            throw new Exception();
        }

        [HttpGet("{id}/print/temperature_sheet")]
        public IActionResult PrintTemperatureSheet([FromQuery] int id)
        {
            // TODO: implement PrintTemperatureSheet
            throw new Exception();
        }

        [HttpGet("{id}/print/ultrasound")]
        public IActionResult PrintUltrasound([FromQuery] int id)
        {
            // TODO: implement PrintUltrasound
            throw new Exception();
        }

        [HttpGet("{id}/print/xray_analyze")]
        public IActionResult PrintXrayAnalyze([FromQuery] int id)
        {
            // TODO: implement PrintXrayAnalyze
            throw new Exception();
        }

        [HttpGet("/print/appointment_sheet")]
        public IActionResult PrintAppointmentSheet()
        {
            // TODO: implement PrintAppointmentSheet
            throw new Exception();
        }

        [HttpGet("/print/entrance_journal")]
        public IActionResult PrintEntranceJournal()
        {
            // TODO: implement PrintEntranceJournal
            throw new Exception();
        }

        [HttpGet("print_stat")]
        public IActionResult PrintStat()
        {
            // TODO: implement PrintStat
            throw new Exception();
        }

    }
}
