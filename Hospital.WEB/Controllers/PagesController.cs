using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers
{
    
    public class PagesController : ControllerBase
    {
        private readonly ILogger<PagesController> _log;

        public PagesController(ILogger<PagesController> logger)
        {
            _log = logger;
            _log.LogDebug("debug log test");
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            // TODO: implement Index
            throw new Exception();
        }

        [HttpGet("/faq")]
        public IActionResult FAQ()
        {
            // TODO: implement FAQ
            throw new Exception();
        }
    }
}
