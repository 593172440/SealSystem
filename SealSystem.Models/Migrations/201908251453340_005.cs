namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _005 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SealUseUnitInfors", "SealUseUnitInforList_Id", "dbo.SealUseUnitInforLists");
            DropIndex("dbo.SealUseUnitInfors", new[] { "SealUseUnitInforList_Id" });
            AddColumn("dbo.SealUseUnitInfors", "UnitClassification", c => c.String());
            AddColumn("dbo.SealUseUnitInfors", "EnterpriseDocumentsType", c => c.String());
            AddColumn("dbo.SealUseUnitInfors", "TheUnitType", c => c.String());
            DropColumn("dbo.SealUseUnitInfors", "SealUseUnitInforList_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SealUseUnitInfors", "SealUseUnitInforList_Id", c => c.Int(nullable: false));
            DropColumn("dbo.SealUseUnitInfors", "TheUnitType");
            DropColumn("dbo.SealUseUnitInfors", "EnterpriseDocumentsType");
            DropColumn("dbo.SealUseUnitInfors", "UnitClassification");
            CreateIndex("dbo.SealUseUnitInfors", "SealUseUnitInforList_Id");
            AddForeignKey("dbo.SealUseUnitInfors", "SealUseUnitInforList_Id", "dbo.SealUseUnitInforLists", "Id");
        }
    }
}
