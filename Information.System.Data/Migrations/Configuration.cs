using System.Data.Entity.Migrations;

namespace Information.System.Data.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<InformationSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            ContextKey = "InformationSystem.Data.InformationSystemDbContext";
        }

        protected override void Seed(InformationSystemDbContext context)
        {
        }
    }
}
