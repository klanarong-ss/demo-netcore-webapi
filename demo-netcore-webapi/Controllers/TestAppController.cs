using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace demo_netcore_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestAppController : ControllerBase
    {
        public TestAppController()
        {

        }

        [HttpGet]
        [Route("test01")]
        public IActionResult test01()
        {
            return Ok("Test Success");
        }

        [HttpGet]
        [Route("test02")]
        public IActionResult test02()
        {
            return Ok("Test Success-222");
        }

        [HttpGet]
        [Route("test03")]
        public IActionResult test03()
        {
            return Ok("Test Success-333");
        }

        [HttpGet]
        [Route("test04")]
        public IActionResult test04()
        {
            return Ok("Test Success-444");
        }

        [HttpGet]
        [Route("test05")]
        public IActionResult test05()
        {
            return Ok("Test Success-555");
        }

        [HttpGet]
        [Route("test06")]
        public IActionResult test06()
        {
            return Ok("Test Success-666");
        }
    }
}
