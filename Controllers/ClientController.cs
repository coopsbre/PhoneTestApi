using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PhoneTestApi.Client
{
    // CONTROLLER LAYER
    [ApiController]

    // ROUTING LAYER
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        // ACTION LAYER — GET /client
        [HttpGet]
        public IActionResult GetAllClients()
        {
            var clients = new[]
            {
                new { Id = 1, Name = "Alice", Email = "alice@example.com" },
                new { Id = 2, Name = "Bob", Email = "bob@example.com" }
            };

            // RESPONSE LAYER
            return Ok(clients);
        }

        // ACTION LAYER — POST /client
        [HttpPost]
        public IActionResult CreateClient([FromBody] CreateClientRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var newClient = new
            {
                Id = 4,
                Name = request.Name,
                Email = request.Email
            };

            return Created("/client/4", newClient);
        }
    }

    // FOUNDATION + MODEL BINDING + VALIDATION
    public class CreateClientRequest
    {
        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
