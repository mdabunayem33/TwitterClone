using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TwitterCloneApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = new[]
            {
                new { Id = 1, Name = "Naim", Username = "naim" },
                new { Id = 2, Name = "John Doe", Username = "johndoe" },
                new { Id = 3, Name = "Jane Doe", Username = "janedoe" }
            };

            return Ok(users);
        }
    }
}