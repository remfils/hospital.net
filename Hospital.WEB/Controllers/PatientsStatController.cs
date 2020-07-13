using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers
{
    [Route("patients")]
    public class PatientsStatController : ControllerBase
    {
        [HttpGet("stat")]
        public IActionResult GetStat()
        {
            // TODO: implement GetStat
            throw new Exception();
        }

    }
}
