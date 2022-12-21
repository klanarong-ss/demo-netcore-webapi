﻿using Microsoft.AspNetCore.Http;
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
    }
}
