namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _003 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SealApprovalUnitInfors", "SealInforNew_Id", "dbo.SealInforNews");
            DropIndex("dbo.SealApprovalUnitInfors", new[] { "SealInforNew_Id" });
            AddColumn("dbo.SealInforNews", "SealApprovalUnitInfor_Id", c => c.Int(nullable: false));
            AddColumn("dbo.SealInforNews", "SealMakingUnitInfor_Id", c => c.Int(nullable: false));
            DropColumn("dbo.SealApprovalUnitInfors", "SealInforNew_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SealApprovalUnitInfors", "SealInforNew_Id", c => c.Int(nullable: false));
            DropColumn("dbo.SealInforNews", "SealMakingUnitInfor_Id");
            DropColumn("dbo.SealInforNews", "SealApprovalUnitInfor_Id");
            CreateIndex("dbo.SealApprovalUnitInfors", "SealInforNew_Id");
            AddForeignKey("dbo.SealApprovalUnitInfors", "SealInforNew_Id", "dbo.SealInforNews", "Id");
        }
    }
}
