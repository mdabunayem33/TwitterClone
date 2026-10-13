using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Domain.Entities;
using TwitterCloneApi.Attributes;

namespace TwitterCloneApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TwittersController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public TwittersController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Helper or Internal method should be private
        private void GetTweet()
        {
            var connectionString = _configuration.GetValue<string>("Logging:LogLevel:Default");
        }

        [Tweet]
        [HttpGet]
        public IActionResult GetTweets()
        {
            var tweets = new List<Tweet>
            {
                new Tweet("my first tweet")
                {
                    UserId = Guid.NewGuid(),
                    Content = "Hello, world!"
                },
                new Tweet("my second tweet")
                {
                    UserId = Guid.NewGuid(),
                    Content = "This is my second tweet."
                }
            };

            return Ok(tweets);
        }
    }
}