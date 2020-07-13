using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers
{
    [Route("users")]
    public class UsersController : ControllerBase
    {
        [HttpGet("profile")]
        public IActionResult GetProfile()
        {
            // TODO: implement GetProfile
            throw new Exception();
        }

        // TODO: post maybe?
        [HttpPatch("update_profile")]
        public IActionResult UpdateProfile()
        {
            // TODO: implement UpdateProfile
            throw new Exception();
        }

    }
}
