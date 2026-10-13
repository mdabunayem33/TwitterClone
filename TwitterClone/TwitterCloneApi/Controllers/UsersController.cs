using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TwitterCloneApi.Controllers
{
    //api/users
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {

        public UsersController()
        {
        }

        // /api/users
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(new List<object>
            {

                new
                {
                    UserId = Guid.NewGuid(),
                    UserName = "user1",
                },

                new
                {
                    UserId = Guid.NewGuid(),
                    UserName = "user2",
                },


            });
        }


        // /api/users
        [HttpPost]
        [AllowAnonymous]
        public IActionResult CreateUser()
        {
            return Ok(new
            {
                UserId = Guid.NewGuid(),
                UserName = "newuser",
            });

        }
        
        
        // /api/users/{id}
        [HttpGet("{id}")]
        public IActionResult GetUserById([FromRoute] Guid id)
        {
            return Ok(new
            {
                UserId = id,
                UserName = "user" + id.ToString(),
            });

        }



        // PUT /api.users/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateUser([FromRoute] Guid id)
        {
            return Ok(new
            {
                UserId = id,
                UserName = "updateduser" + id.ToString(),
            });

        }



        // i want to update only user phone number
        // patch /api/users/{id}/phoneNumber
        [HttpPatch("{id}/phonenumber")]
        public IActionResult UpdateUserPhoneNumber([FromRoute] Guid id, [FromBody] string phoneNumber)
        {
            return Ok(new
            {
                UserId = id,
                PhoneNumber = phoneNumber,
            });
        }



        // DELETE /api/users/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteUser([FromRoute] Guid id)
        {
            return Ok(new
            {
                UserId = id,
                Message = "User deleted successfully",
            });
        }

        }
}