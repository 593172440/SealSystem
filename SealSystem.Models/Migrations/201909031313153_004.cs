namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _004 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FileAndImages", "SealInforNew_Id", "dbo.SealInforNews");
            DropIndex("dbo.FileAndImages", new[] { "SealInforNew_Id" });
            AddColumn("dbo.FileAndImages", "SealInforNew_SealInforNum", c => c.String());
            DropColumn("dbo.FileAndImages", "SealInforNew_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FileAndImages", "SealInforNew_Id", c => c.Int(nullable: false));
            DropColumn("dbo.FileAndImages", "SealInforNew_SealInforNum");
            CreateIndex("dbo.FileAndImages", "SealInforNew_Id");
            AddForeignKey("dbo.FileAndImages", "SealInforNew_Id", "dbo.SealInforNews", "Id");
        }
    }
}
