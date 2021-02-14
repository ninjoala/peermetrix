using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PeerMetrix.Data;
using PeerMetrix.Dtos;
using PeerMetrix.Models;

namespace PeerMetrix.Controllers    
{
    //[[Authorize(Policy = "RequireAdministratorRole")]]
    [ApiController]
    [Route("api/moderator")]
    //[Authorize]
    public class AdminController : ControllerBase
    {
        private IQueryRepo _repo;
        private IMapper _mapper;

        public AdminController(IQueryRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpDelete("{id}")]
        public ActionResult DeletePost(int id)
        {
            //delete literally any post
            return NoContent();
        }

        [HttpPatch]
        public ActionResult <TopicReadDto> UpdateTopic()
        {
            //edit any topic
            return NoContent();
        }

        [HttpPatch]

        public ActionResult <Post> UpdatePost()
        {
            //edit any post
            return NoContent();
        }

        //you would expose the repo with the appropriate function and use that in here, 
        //used context for brevity

        // [HttpGet]
        // public IEnumerable<Post> GetAllFlaggedPosts()
        // {
        //     return _context.Posts.Where(p => p.isflagged == true);
        // }

    }
}