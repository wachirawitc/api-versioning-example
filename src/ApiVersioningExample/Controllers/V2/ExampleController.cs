using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningExample.Controllers.V2
{
    [ApiVersion("2.0")]
    [ApiController]
    [Route("[controller]")]
    public class ExampleController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello from V2";
        }
    }
}