﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using InformationSystem.Models;

namespace InformationSystem.Data.Common.Models
{
    public abstract class BaseModel<TKey> : IAuditInfo, IDeletableEntity
    {
        [Key]
        public TKey Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        //public ApplicationUser User { get; set; }


        [Index]
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        //public ApplicationUser DeletedUser { get; set; }
    }
}
