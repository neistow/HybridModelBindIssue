using HybridModelBinding;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExampleController : ControllerBase
    {
        [HttpPut]
        public ActionResult DoABarrelRoll([FromHybrid] ExampleModel model)
        {
            return Ok(model);
        }
        
        [HttpPut("v2")]
        public ActionResult DoABarrelRollV2([FromBody] ExampleModel model)
        {
            return Ok(model);
        }
    }
}