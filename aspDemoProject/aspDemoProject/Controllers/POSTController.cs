using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aspDemoProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class POSTController : ControllerBase
    {
        //POST api/postexample
        [HttpPost]
        public ActionResult<string> Post([FromBody] string value)
        {
            return Ok($"received: {value}");
        }

        //POST api/postexample/data
        [HttpPost("data")]
        public ActionResult<object> PostData([FromBody] DataModel data)
        {
            return Ok(data);
        }
    }
}
