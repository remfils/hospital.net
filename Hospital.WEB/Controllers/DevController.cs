using Hospital.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers
{
    [Route("dev")]
    public class DevController : ControllerBase
    {
        private readonly ILogger<DevController> _log;

        public DevController(ILogger<DevController> logger, IOptions<HospitalOptions> settings)
        {
            _log = logger;
            _log.LogDebug("this is test : {0}", settings.Value.HospitalConnectionString);
        }

        [HttpGet]
        public IActionResult Info()
        {
            // TODO: implement Info
            throw new Exception();
        }

        [HttpGet("concrements")]
        public IActionResult Concrements()
        {
            // TODO: implement Concrements
            throw new Exception();
        }

        [HttpPost("concrements")]
        public IActionResult CreateConcrements()
        {
            // TODO: implement CreateConcrements
            throw new Exception();
        }

        [HttpDelete("concrements/{id}")]
        public IActionResult DeleteConcremens([FromQuery]int id)
        {
            // TODO: implement DeleteConcremens
            throw new Exception();
        }

        [HttpGet("error_500")]
        public IActionResult Error500()
        {
            // TODO: implement Error500
            throw new Exception();
        }

        [HttpGet("prediction")]
        public IActionResult Prediction()
        {
            // TODO: implement Prediction
            throw new Exception();
        }

        [HttpGet("expenses")]
        public IActionResult Expenses()
        {
            // TODO: implement Expenses
            throw new Exception();
        }

        [HttpGet("clear_cache")]
        public IActionResult ClearCache()
        {
            // TODO: implement ClearCache
            throw new Exception();
        }
    }
}
