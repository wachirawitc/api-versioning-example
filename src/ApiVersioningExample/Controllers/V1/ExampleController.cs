using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningExample.Controllers.V1
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("v{version:apiVersion}/[controller]")]
    public class ExampleController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello from V1";
        }
    }
}