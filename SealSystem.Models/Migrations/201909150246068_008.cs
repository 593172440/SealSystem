namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _008 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SealTheDeliveryInformations", "SealMakingUnitInfor_Id_MakingUnitCode", "dbo.SealMakingUnitInfors");
            DropIndex("dbo.SealTheDeliveryInformations", new[] { "SealMakingUnitInfor_Id_MakingUnitCode" });
            AddColumn("dbo.TheOrders", "TakeSealName", c => c.String());
            AddColumn("dbo.TheOrders", "TakeTime", c => c.DateTime());
            AddColumn("dbo.TheOrders", "IdCard", c => c.String());
            AddColumn("dbo.TheOrders", "Phone", c => c.String());
            AddColumn("dbo.TheOrders", "DeliveryTime", c => c.DateTime());
            AddColumn("dbo.TheOrders", "UpTime", c => c.DateTime());
            DropTable("dbo.SealTheDeliveryInformations");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SealTheDeliveryInformations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SealMakingUnitInfor_Id_MakingUnitCode = c.Int(nullable: false),
                        TakeSealName = c.String(),
                        TakeTime = c.DateTime(),
                        IdCard = c.String(),
                        Phone = c.String(),
                        DeliveryTime = c.DateTime(),
                        UpTime = c.DateTime(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.TheOrders", "UpTime");
            DropColumn("dbo.TheOrders", "DeliveryTime");
            DropColumn("dbo.TheOrders", "Phone");
            DropColumn("dbo.TheOrders", "IdCard");
            DropColumn("dbo.TheOrders", "TakeTime");
            DropColumn("dbo.TheOrders", "TakeSealName");
            CreateIndex("dbo.SealTheDeliveryInformations", "SealMakingUnitInfor_Id_MakingUnitCode");
            AddForeignKey("dbo.SealTheDeliveryInformations", "SealMakingUnitInfor_Id_MakingUnitCode", "dbo.SealMakingUnitInfors", "Id");
        }
    }
}
