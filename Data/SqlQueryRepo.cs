using System;
using System.Collections.Generic;
using System.Linq;
using PeerMetrix.Models;

namespace PeerMetrix.Data
{
    public class SqlQueryRepo : IQueryRepo
    {
        private PeerMetrixContext _context;

        public SqlQueryRepo(PeerMetrixContext context)
        {
            _context = context;
        }

        public void CreateTopic(Topic topic)
        {
            if (topic == null)
            {
                throw new ArgumentNullException(nameof(topic));
            }

            _context.Topics.Add(topic);
        }

        public IEnumerable<Topic> GetAllTopics()
        {
            return _context.Topics.ToList();
        }

        public Topic GetTopicById(int id)
        {
            return _context.Topics.Where(t => t.TopicID == id).FirstOrDefault();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateTopic(Topic topic)
        {
            //do nothing
        }
    }
}