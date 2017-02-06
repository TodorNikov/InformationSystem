using InformationSystem.Models;
using System;

namespace InformationSystem.Data.Common.Models
{
    public interface IAuditInfo
    {
        DateTime CreatedOn { get; set; }
        DateTime? ModifiedOn { get; set; }
       // ApplicationUser User { get; set; }
    }
}
