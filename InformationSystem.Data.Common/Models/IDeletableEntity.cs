using InformationSystem.Models;
using System;

namespace InformationSystem.Data.Common.Models
{
    public interface IDeletableEntity
    {
        bool IsDeleted { get; set; }
        DateTime? DeletedOn { get; set; }
        //ApplicationUser DeletedUser { get; set; }
    }
}
