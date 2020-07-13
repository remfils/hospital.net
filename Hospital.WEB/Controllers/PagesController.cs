using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers
{
    
    public class PagesController : ControllerBase
    {
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
