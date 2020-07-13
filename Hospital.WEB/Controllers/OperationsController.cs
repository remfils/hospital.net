using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers
{
    [Route("operations")]
    public class OperationsController : ControllerBase
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            // TODO: implement Index
            throw new Exception();
        }

        [HttpGet("times_1")]
        public IActionResult TimesOne()
        {
            // TODO: implement TimesOne
            throw new Exception();
        }
    }
}
