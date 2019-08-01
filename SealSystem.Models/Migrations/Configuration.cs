namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SealSystem.Models.SSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SealSystem.Models.SSContext context)
        {
            context.UserPermissions.AddOrUpdate(
                new UserPermissions { User_Id = 1, Menu_Id = 16,Add=true,Edit=true,Details=true,Delete=true }
                );

        }
    }
}
