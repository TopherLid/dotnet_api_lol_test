using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using p1.core.Interfaces;
using p1.infrastructure.Repositories;
using System.Threading.Tasks;

namespace p1.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {

        private readonly IPostRepository _postRepository;

        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetPosts() 
        {
            var post = await _postRepository.GetPosts();
            return Ok(post);
        }
    }
}
