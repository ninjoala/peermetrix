using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PeerMetrix.Data;
using PeerMetrix.Dtos;
using PeerMetrix.Models;

namespace PeerMetrix.Controllers    
{
    [ApiController]
    [Route("api/user")]
    //[Authorize]
    public class UserController : ControllerBase
    {
        private IQueryRepo _repo;
        private IMapper _mapper;

        public UserController(IQueryRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
       [HttpGet]
       public ActionResult GetAllTopics()
       {
           var topicItems = _repo.GetAllTopics();

           return Ok(topicItems);
       }

       [HttpPost]
       public ActionResult<TopicCreateDto> CreateTopic(TopicCreateDto topicCreateDto)
       {
           var topicModel = _mapper.Map<Topic>(topicCreateDto);

           _repo.CreateTopic(topicModel);
           _repo.SaveChanges();

           var topicReadDto = _mapper.Map<TopicReadDto>(topicModel);

           return CreatedAtRoute(nameof(GetTopicById), new {Id = topicReadDto.TopicID}, topicReadDto);
       }

       [HttpGet("{id}", Name="GetTopicById")]
       public ActionResult <TopicReadDto> GetTopicById(int id)
       {
           var topicItem = _repo.GetTopicById(id);

           if (topicItem != null)
           {
               return Ok(_mapper.Map<TopicReadDto>(topicItem));
           }

           return NotFound();
       }

    //    [HttpPost]
    //    public ActionResult CreatePost()
    //    {
    //        return Ok();
    //    }

       [HttpDelete]
        public ActionResult DeleteOwnPost()
       {
           return Ok();
       }

       [HttpPut("{id}")]
       public ActionResult EditOwnPost(int id, TopicUpdateDto topicUpdateDto)
       {
           //gather userID from identity
           
           //get post

           //check if post user id matches identity id

           //if it does, run code

           //if not, return 'not allowed HttpResponse'

           var topicModelFromRepo = _repo.GetTopicById(id);
           if (topicModelFromRepo == null)
           {
               return NotFound();
           }

           _mapper.Map(topicUpdateDto, topicModelFromRepo);

           _repo.UpdateTopic(topicModelFromRepo);

           _repo.SaveChanges();


           return NoContent();
       }

       //add httppatch
       //people like this better
    }
}