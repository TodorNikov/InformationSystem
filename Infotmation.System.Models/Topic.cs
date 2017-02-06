using InformationSystem.Data.Common.Models;
using System.Collections.Generic;
namespace InfotmationSystem.Data.Models
{
    public class Topic : BaseModel<int>
    {
        public Topic()
        {
            this.SubTopics = new HashSet<SubTopic>();
        }
        public int SubTopicId { get; set; }
        public int View { get; set; }
        public string TopicName { get; set; }
        public short Reating { get; set; }

        // Relation between tables
        public virtual ICollection<SubTopic> SubTopics { get; set; }
        
    }
}
