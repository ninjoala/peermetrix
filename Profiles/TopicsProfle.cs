using AutoMapper;
using PeerMetrix.Dtos;
using PeerMetrix.Models;

namespace PeerMetrix.Profiles
{
    public class TopicsProfile : Profile
    {

        public TopicsProfile()
        {
            //Source -> Target
            CreateMap<Topic, TopicCreateDto>();
            CreateMap<Topic, TopicReadDto>();
            CreateMap<TopicCreateDto, Topic>();
            CreateMap<TopicUpdateDto, Topic>();
            CreateMap<Topic, TopicUpdateDto>();
        }
    }
}