using InformationSystem.Data.Common.Models;

namespace InfotmationSystem.Data.Models
{
    public class Vote : BaseModel<int>
    {
        public int PostId { get; set; }

        // Relation between tables
        public virtual Post Posts { get; set; }
    }
}
