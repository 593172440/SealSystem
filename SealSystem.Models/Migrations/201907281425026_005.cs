namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _005 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SealInfors", "SealSpecification", c => c.String());
            AddColumn("dbo.SealInfors", "SealShape", c => c.String());
            AddColumn("dbo.SealInfors", "EngravingType", c => c.String());
            AddColumn("dbo.SealInfors", "EngravingLevel", c => c.String());
            DropColumn("dbo.SealImageDatas", "SealSpecification");
            DropColumn("dbo.SealImageDatas", "SealShape");
            DropColumn("dbo.SealImageDatas", "EngravingType");
            DropColumn("dbo.SealImageDatas", "EngravingLevel");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SealImageDatas", "EngravingLevel", c => c.String());
            AddColumn("dbo.SealImageDatas", "EngravingType", c => c.String());
            AddColumn("dbo.SealImageDatas", "SealShape", c => c.String());
            AddColumn("dbo.SealImageDatas", "SealSpecification", c => c.String());
            DropColumn("dbo.SealInfors", "EngravingLevel");
            DropColumn("dbo.SealInfors", "EngravingType");
            DropColumn("dbo.SealInfors", "SealShape");
            DropColumn("dbo.SealInfors", "SealSpecification");
        }
    }
}
