using Microsoft.AspNetCore.Mvc;

namespace SmpPharmacyServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PharmacyController : ControllerBase
    {
        [HttpGet("test")]
        public IActionResult GetTest()
        {
            return Ok(new { message = "Pharmacy API is working!" });
        }
    }
}
