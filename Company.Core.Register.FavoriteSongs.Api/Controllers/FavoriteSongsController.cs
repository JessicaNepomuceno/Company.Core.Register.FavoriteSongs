using Microsoft.AspNetCore.Mvc;

namespace Company.Core.Register.FavoriteSongs.Api.Controllers
{
    [ApiController]
    [Route(template: $"api")]
    public class FavoriteSongsController : ControllerBase
    {
        [HttpPost(template: "create")]
        public Task<IActionResult> CreateAsync()
        {
            return Task.FromResult<IActionResult>(Ok());

        }
    }
}
