using InformationSystem.Data.Common.Models;
using System.Collections.Generic;

namespace InfotmationSystem.Data.Models
{
    public class Post : BaseModel<int> 
    {
        public Post()
        {
            this.ParentPosts = new HashSet<Post>();
            this.Votes = new HashSet<Vote>();
        }
        
        public string Answer { get; set; }
        public int VoteId { get; set; }
        public string SubTopic  { get; set; }
        public int ParentPost { get; set; }

        // Relation between tables
        public virtual SubTopic Subtopics { get; set; }
        public virtual ICollection<Post> ParentPosts { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }
        
    }
}
