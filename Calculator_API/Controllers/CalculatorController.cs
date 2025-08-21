using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calculator_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet(template: "sum")]
        public IActionResult GetSum([FromQuery] int a, [FromQuery] int b)
        {
            var result = a + b;
            return Ok(new {a,b, result});
        }
        [HttpGet(template: "rest")]
        public IActionResult GetRest([FromQuery] int a, [FromQuery] int b)
        {
            var result = a - b;
            return Ok(new {a,b, result});
        }
        [HttpGet(template: "prod")]
        public IActionResult GetProd([FromQuery] int a, [FromQuery] int b)
        {
            var result = a * b;
            return Ok(new {a,b, result});
        }
        [HttpGet(template: "div")]
        public IActionResult GetDiv([FromQuery] int a, [FromQuery] int b)
        {
            if (b == 0) 
            {
                return BadRequest(new {error = "Division by zero"});
            }
            var result = a / b;
            return Ok(new {a,b, result});
        }
    }
}

