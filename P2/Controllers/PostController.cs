using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using P2.DTOs;
using P2.Services;

namespace P2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        IPostService _titlesService;

        public PostController(IPostService titlesService)
        {
            _titlesService = titlesService;
        }

        [HttpGet]

        public async Task<IEnumerable<PostDTO>> Get() => await _titlesService.Get();
    }
}
