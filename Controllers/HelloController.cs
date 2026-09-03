using System.Runtime.Versioning; //FOUNDATION LAYER: 
                                 // Framework-level namespaces. 
                                 // These come from .NET itself and ASP.NET.
using Microsoft.AspNetCore.Mvc;  // FOUNDATION LAYER:
                                 // Gives access to ControllerBase, ApiControoler, 
                                 // IActionResult, routing attributes, and response helpers.

namespace PhoneTestApi.Controllers  //CONTROLLER LAYER: 
                                    //Defines the namespace where the controllers live.
{
    [ApiController]                 //CONTROLLER LAYER: 
                                    //Turnes this class into a true API controller. 
                                    //Enables: 
                                    // - Automatic model validation
                                    // - Automatic 400 responses 
                                    // - Better parameter binding 
                                    // - Requires attribute routing

    [Route("[controller]")]         // ROUTING LAYER: 
                                    // Uses the route token [controller]
                                    // HelloController => "/hello"
                                    // This defines the base URL path for this controller.
    public class HelloController : ControllerBase //CONTROLLER LAYER: 
                                                  // Inherits from ControllerBases: 
                                                  // - No MVC views 
                                                  // - JSON-only responses
                                                  // - Provides Ok(), BadRequest(), NotFound(), etc.
    {
        [HttpGet] //ACTION LAYER: 
                  //Maps this method to an HTTP GET requests. 
                  //GET /hello     
        public IActionResult Get() //ACTION LAYER: 
                                   // IActionResult allows flexible status codes.
                                   // This method handles incoming GET requests.
        {
            
            return Ok(new {message = "Hello from Brendon"}); //RESPONSE LAYER: 
                                                             // Ok(...) => returns HTTP 200 Success.
                                                             // The anonymouse object becoms JSON: 
                                                             // {"message": "Hello from Brendon"}
        }
    }
}