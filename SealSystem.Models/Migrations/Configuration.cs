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
                new SealState { Code = "1", Name = "������" },
                new SealState { Code = "2", Name = "�ѳн�" },
                new SealState { Code = "3", Name = "������" },
                new SealState { Code = "4", Name = "�ѽ���" },
                new SealState { Code = "5", Name = "�ѱ���" },
                new SealState { Code = "6", Name = "�ѽ���" },
                new SealState { Code = "7", Name = "�ѹ�ʧ" }
                );
        }
    }
}
