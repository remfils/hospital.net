using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.WEB.Controllers
{
    [Route("voice")]
    public class VoiceController : ControllerBase
    {
        [HttpPost("recognize_command")]
        public IActionResult RecognizeCommand()
        {
            // TODO: implement RecognizeCommand
            throw new Exception();
        }

    }

}
