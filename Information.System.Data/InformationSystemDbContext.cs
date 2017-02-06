using System;
using System.Linq;
using System.Data.Entity;
using InfotmationSystem.Data.Models;
using InformationSystem.Data.Common.Models;
using Information.System.Data.Migrations;

namespace Information.System.Data
{
    public class InformationSystemDbContext : DbContext
    {
        public InformationSystemDbContext() : base("InforamtionSystem")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<InformationSystemDbContext, Configuration>());
        }

        public IDbSet<Vote> Votes { get; set; }
        public IDbSet<Post> Posts { get; set; }
        public IDbSet<Topic> Topics { get; set; }
        public IDbSet<SubTopic> SubTopics { get; set; }

        public override int SaveChanges()
        {
            this.ApplyAuditInfoRules();
            return base.SaveChanges();
        }

        private void ApplyAuditInfoRules()
        {
            // Approach via @julielerman: http://bit.ly/123661P
            foreach (var entry in
                this.ChangeTracker.Entries()
                    .Where(
                        e =>
                        e.Entity is IAuditInfo && ((e.State == EntityState.Added) || (e.State == EntityState.Modified))))
            {
                var entity = (IAuditInfo)entry.Entity;
                if (entry.State == EntityState.Added && entity.CreatedOn == default(DateTime))
                {
                    entity.CreatedOn = DateTime.UtcNow;
                }
                else
                {
                    entity.ModifiedOn = DateTime.UtcNow;
                }
            }
        }
    }
}
