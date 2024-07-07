using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aspDemoProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        // GET api/Calc/SUM/{value1, value2}
        [HttpGet("Sum")]
        public ActionResult<string> Sum(int val1, int val2)
        {

            return $"res = {val1 + val2}";
        }
        // GET api/Calc/Min/{value1, value2}
        [HttpGet("Min")]
        public ActionResult<string> Minus(int val1, int val2)
        {

            return $"res = {val1 - val2}";
        }
        // GET api/Calc/Mul/{value1, value2}
        [HttpGet("Mul")]
        public ActionResult<string> Multiply(int val1, int val2)
        {

            return $"res = {val1 * val2}";
        }
        // GET api/Calc/Div/{value1, value2}
        [HttpGet("Div")]
        public ActionResult<string> Divide(double val1, double val2)
        {

            return $"res = {val1 / val2}";
        }
    }
}
