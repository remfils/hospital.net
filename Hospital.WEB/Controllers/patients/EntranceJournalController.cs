using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers.patients
{
    [Route("patients")]
    public class EntranceJournalController : ControllerBase
    {
        [HttpGet("/entrance_journal_nurse")]
        public IActionResult GetEntranceJournalNurse()
        {
            // TODO: implement GetEntranceJournalNurse
            throw new Exception();
        }
    }
}
