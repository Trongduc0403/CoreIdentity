using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreIdentity.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ExampleController : Controller
    {
        [HttpGet]
        [Authorize]
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

        [Authorize]
        [HttpGet("protected")]
        public IActionResult Protected()
        {
            return Ok(new { Message = "This is a protected endpoint" });
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("admin-only")]
        public IActionResult AdminOnly()
        {
            return Ok(new { Message = "Only admins can see this" });
        }
    }
}
