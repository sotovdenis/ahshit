using ahshitherewegoagain.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ahshitherewegoagain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComponentController : ControllerBase
    {
        [HttpGet] 
        public async Task<ActionResult<List<Component>>> GetAllComponents()
        {
            var components = new List<Component>{
                new Component
                {
                    Id = 1,
                    Name = "Vlad Pidor",
                    StorageId = 1,
                    Count = 1,
                    MinCount = 0,
                }
            };
            return Ok(components);
        }
    }
}
