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
            context.SealStates.AddOrUpdate(
                new SealState { Code = "1", Name = "已审批" },
                new SealState { Code = "2", Name = "已承接" },
                new SealState { Code = "3", Name = "已制作" },
                new SealState { Code = "4", Name = "已交付" },
                new SealState { Code = "5", Name = "已报废" },
                new SealState { Code = "6", Name = "已缴销" },
                new SealState { Code = "7", Name = "已挂失" }
                );
        }
    }
}
