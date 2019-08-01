namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _006 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.FileAndImages", new[] { "SealInfor_Id" });
            AddColumn("dbo.FileAndImages", "Note", c => c.String());
            AlterColumn("dbo.FileAndImages", "SealInfor_Id", c => c.Int());
            CreateIndex("dbo.FileAndImages", "SealInfor_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.FileAndImages", new[] { "SealInfor_Id" });
            AlterColumn("dbo.FileAndImages", "SealInfor_Id", c => c.Int(nullable: false));
            DropColumn("dbo.FileAndImages", "Note");
            CreateIndex("dbo.FileAndImages", "SealInfor_Id");
        }
    }
}
