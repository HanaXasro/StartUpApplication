using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StartUpApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalInfoController : ControllerBase
    {
        private readonly PesonalInfo pesonalInfo;

        public PersonalInfoController(PesonalInfo pesonalInfo)
        {
            this.pesonalInfo = pesonalInfo;
        }

        [HttpGet]
        public IActionResult GetPcName()
        {


            return Ok(pesonalInfo);
        }
    }
}
