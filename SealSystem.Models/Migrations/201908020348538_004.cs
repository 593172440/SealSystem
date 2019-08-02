namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _004 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FileAndImages", "SealInfor_Id", "dbo.SealInfors");
            DropIndex("dbo.FileAndImages", new[] { "SealInfor_Id" });
            AddColumn("dbo.FileAndImages", "SealInforNew_Id", c => c.Int());
            CreateIndex("dbo.FileAndImages", "SealInforNew_Id");
            AddForeignKey("dbo.FileAndImages", "SealInforNew_Id", "dbo.SealInforNews", "Id");
            DropColumn("dbo.FileAndImages", "SealInfor_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FileAndImages", "SealInfor_Id", c => c.Int());
            DropForeignKey("dbo.FileAndImages", "SealInforNew_Id", "dbo.SealInforNews");
            DropIndex("dbo.FileAndImages", new[] { "SealInforNew_Id" });
            DropColumn("dbo.FileAndImages", "SealInforNew_Id");
            CreateIndex("dbo.FileAndImages", "SealInfor_Id");
            AddForeignKey("dbo.FileAndImages", "SealInfor_Id", "dbo.SealInfors", "Id");
        }
    }
}
