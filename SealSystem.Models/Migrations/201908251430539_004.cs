namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _004 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SealUseUnitInfors", "Area_Id", "dbo.Areas");
            DropForeignKey("dbo.SealUseUnitInfors", "SealUnitCategory_Id", "dbo.SealUnitCategories");
            DropForeignKey("dbo.SealUseUnitInfors", "SealUnitClass_Id", "dbo.SealUnitClasses");
            DropIndex("dbo.SealUseUnitInfors", new[] { "SealUnitCategory_Id" });
            DropIndex("dbo.SealUseUnitInfors", new[] { "SealUnitClass_Id" });
            DropIndex("dbo.SealUseUnitInfors", new[] { "Area_Id" });
            CreateTable(
                "dbo.SealUseUnitInforLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Types = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.SealApprovalUnitInfors", "Name", c => c.String());
            AddColumn("dbo.SealUseUnitInfors", "SealUseUnitInforList_Id", c => c.Int(nullable: false));
            AddColumn("dbo.SealUseUnitInfors", "Note", c => c.String());
            CreateIndex("dbo.SealUseUnitInfors", "SealUseUnitInforList_Id");
            AddForeignKey("dbo.SealUseUnitInfors", "SealUseUnitInforList_Id", "dbo.SealUseUnitInforLists", "Id");
            DropColumn("dbo.SealUseUnitInfors", "SealUnitCategory_Id");
            DropColumn("dbo.SealUseUnitInfors", "VoiceQueryPassword");
            DropColumn("dbo.SealUseUnitInfors", "TheZipCode");
            DropColumn("dbo.SealUseUnitInfors", "SealUnitClass_Id");
            DropColumn("dbo.SealUseUnitInfors", "EnterpriseDocumentsType");
            DropColumn("dbo.SealUseUnitInfors", "Area_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SealUseUnitInfors", "Area_Id", c => c.Int(nullable: false));
            AddColumn("dbo.SealUseUnitInfors", "EnterpriseDocumentsType", c => c.String());
            AddColumn("dbo.SealUseUnitInfors", "SealUnitClass_Id", c => c.Int(nullable: false));
            AddColumn("dbo.SealUseUnitInfors", "TheZipCode", c => c.String());
            AddColumn("dbo.SealUseUnitInfors", "VoiceQueryPassword", c => c.String());
            AddColumn("dbo.SealUseUnitInfors", "SealUnitCategory_Id", c => c.Int(nullable: false));
            DropForeignKey("dbo.SealUseUnitInfors", "SealUseUnitInforList_Id", "dbo.SealUseUnitInforLists");
            DropIndex("dbo.SealUseUnitInfors", new[] { "SealUseUnitInforList_Id" });
            DropColumn("dbo.SealUseUnitInfors", "Note");
            DropColumn("dbo.SealUseUnitInfors", "SealUseUnitInforList_Id");
            DropColumn("dbo.SealApprovalUnitInfors", "Name");
            DropTable("dbo.SealUseUnitInforLists");
            CreateIndex("dbo.SealUseUnitInfors", "Area_Id");
            CreateIndex("dbo.SealUseUnitInfors", "SealUnitClass_Id");
            CreateIndex("dbo.SealUseUnitInfors", "SealUnitCategory_Id");
            AddForeignKey("dbo.SealUseUnitInfors", "SealUnitClass_Id", "dbo.SealUnitClasses", "Id");
            AddForeignKey("dbo.SealUseUnitInfors", "SealUnitCategory_Id", "dbo.SealUnitCategories", "Id");
            AddForeignKey("dbo.SealUseUnitInfors", "Area_Id", "dbo.Areas", "Id");
        }
    }
}
