namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _002 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SealInforNews", "SealApprovalUnitInfor_Id_ApprovalUnitCode", c => c.Int(nullable: false));
            CreateIndex("dbo.SealInforNews", "SealApprovalUnitInfor_Id_ApprovalUnitCode");
            AddForeignKey("dbo.SealInforNews", "SealApprovalUnitInfor_Id_ApprovalUnitCode", "dbo.SealApprovalUnitInfors", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SealInforNews", "SealApprovalUnitInfor_Id_ApprovalUnitCode", "dbo.SealApprovalUnitInfors");
            DropIndex("dbo.SealInforNews", new[] { "SealApprovalUnitInfor_Id_ApprovalUnitCode" });
            DropColumn("dbo.SealInforNews", "SealApprovalUnitInfor_Id_ApprovalUnitCode");
        }
    }
}
