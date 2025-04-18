using Microsoft.AspNetCore.Mvc;

namespace CoreIdentity.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExampleController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Message = "Hello from API!" });
        }

        [HttpPost]
        public IActionResult Post([FromBody] ExampleModel model)
        {
            return CreatedAtAction(nameof(Get), new { id = 1, model.Name });
        }

        public class ExampleModel
        {
            public string Name { get; set; }
        }
    }
}
