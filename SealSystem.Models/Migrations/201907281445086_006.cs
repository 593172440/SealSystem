namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _006 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SealInfors", "ApprovalTime", c => c.DateTime());
            AlterColumn("dbo.SealInfors", "UndertakeTime", c => c.DateTime());
            AlterColumn("dbo.SealInfors", "MakingTime", c => c.DateTime());
            AlterColumn("dbo.SealInfors", "DeliveryTime", c => c.DateTime());
            AlterColumn("dbo.SealInfors", "ScrapTime", c => c.DateTime());
            AlterColumn("dbo.SealInfors", "HandTime", c => c.DateTime());
            AlterColumn("dbo.SealInfors", "LossTime", c => c.DateTime());
            AlterColumn("dbo.SealInfors", "LastAnnualTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SealInfors", "LastAnnualTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SealInfors", "LossTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SealInfors", "HandTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SealInfors", "ScrapTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SealInfors", "DeliveryTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SealInfors", "MakingTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SealInfors", "UndertakeTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SealInfors", "ApprovalTime", c => c.DateTime(nullable: false));
        }
    }
}
