using InformationSystem.Data.Common.Models;
using System.Collections.Generic;

namespace InfotmationSystem.Data.Models
{
    public class SubTopic : BaseModel<int>
    {
        public SubTopic()
        {
            this.Posts = new HashSet<Post>();
        }

        public int TopicId { get; set; }
        public int Postid { get; set; }
        public int View { get; set; }
        public string SubTopicName { get; set; }
        public short Reating { get; set; }

        // Relation between tables
        public virtual Topic Topics { get; set; }
        public virtual ICollection<Post> Posts { get; set; }

    }
}
