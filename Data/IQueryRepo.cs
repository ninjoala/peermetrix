using System.Collections.Generic;
using PeerMetrix.Models;

namespace PeerMetrix.Data
{
    public interface IQueryRepo
    {
        IEnumerable<Topic> GetAllTopics();

        Topic GetTopicById(int id);

        void CreateTopic(Topic topic);

        bool SaveChanges();

        void UpdateTopic(Topic topic);
    }
}