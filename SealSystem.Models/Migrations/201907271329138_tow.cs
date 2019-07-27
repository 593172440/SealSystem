namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tow : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SealUseUnitInfors", "Area_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.SealUseUnitInfors", "Area_Id");
            AddForeignKey("dbo.SealUseUnitInfors", "Area_Id", "dbo.Areas", "Id");
            DropColumn("dbo.SealUseUnitInfors", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SealUseUnitInfors", "MyProperty", c => c.String());
            DropForeignKey("dbo.SealUseUnitInfors", "Area_Id", "dbo.Areas");
            DropIndex("dbo.SealUseUnitInfors", new[] { "Area_Id" });
            DropColumn("dbo.SealUseUnitInfors", "Area_Id");
        }
    }
}
