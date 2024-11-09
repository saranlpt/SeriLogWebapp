using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SeriLogWebapp
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestLoggingController : Controller
    {
       [HttpGet("error")]
        public IActionResult GetError()
        {
            throw new Exception("Test Exception");
            
        }

      

        

     
    
      
    }
}
