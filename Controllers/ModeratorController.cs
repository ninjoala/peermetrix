using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PeerMetrix.Data;
using PeerMetrix.Dtos;
using PeerMetrix.Models;

namespace PeerMetrix.Controllers    
{
    //[[Authorize(Policy = "RequireModeratorRole")]]
    [ApiController]
    [Route("api/moderator")]
    //[Authorize]
    public class ModeratorController : ControllerBase
    {
        private IQueryRepo _repo;
        private IMapper _mapper;

        public ModeratorController(IQueryRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        //must add newtonsoft dependency, and json patch
        [HttpPatch]
        public ActionResult FlagPost(int id)
        {
            //this would be a patch to edit the 'isflagged' attribute on post

            return NoContent();

        }

    }
}