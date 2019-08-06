namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _002 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FileAndImages", "SealInforNew_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.FileAndImages", "SealInforNew_Id");
            AddForeignKey("dbo.FileAndImages", "SealInforNew_Id", "dbo.SealInforNews", "Id");
            DropColumn("dbo.FileAndImages", "SealInforNew_SealInforNum");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FileAndImages", "SealInforNew_SealInforNum", c => c.String());
            DropForeignKey("dbo.FileAndImages", "SealInforNew_Id", "dbo.SealInforNews");
            DropIndex("dbo.FileAndImages", new[] { "SealInforNew_Id" });
            DropColumn("dbo.FileAndImages", "SealInforNew_Id");
        }
    }
}
