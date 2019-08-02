namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _002 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddSeals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SealInforNum = c.String(nullable: false),
                        SealContent = c.String(),
                        MakeWay = c.String(),
                        SealMaterial_Id_Code = c.Int(nullable: false),
                        TheProducer = c.String(),
                        Note = c.String(),
                        SealInforNew_Id = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SealInforNews", t => t.SealInforNew_Id)
                .ForeignKey("dbo.SealMaterials", t => t.SealMaterial_Id_Code)
                .Index(t => t.SealMaterial_Id_Code)
                .Index(t => t.SealInforNew_Id);
            
            CreateTable(
                "dbo.SealInforNews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SealCategory_Id_Code = c.Int(nullable: false),
                        SealSpecification = c.String(),
                        SealContent = c.String(),
                        SealMakingUnitInfor_Id_MakingUnitCode = c.Int(nullable: false),
                        SealUseUnitInfor_Id_UnitNumber = c.Int(nullable: false),
                        RegistrationCategory = c.String(),
                        SealShape = c.String(),
                        EngravingType = c.String(),
                        EngravingLevel = c.String(),
                        SealState_Id_Code = c.Int(nullable: false),
                        Attention = c.String(),
                        AttentionIdCard = c.String(),
                        Contact = c.String(),
                        Approval = c.String(),
                        ApprovalTime = c.DateTime(),
                        SealApprovalUnitInfor_Id_ApprovalUnitCode = c.Int(nullable: false),
                        Note = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SealApprovalUnitInfors", t => t.SealApprovalUnitInfor_Id_ApprovalUnitCode)
                .ForeignKey("dbo.SealCategories", t => t.SealCategory_Id_Code)
                .ForeignKey("dbo.SealMakingUnitInfors", t => t.SealMakingUnitInfor_Id_MakingUnitCode)
                .ForeignKey("dbo.SealStates", t => t.SealState_Id_Code)
                .ForeignKey("dbo.SealUseUnitInfors", t => t.SealUseUnitInfor_Id_UnitNumber)
                .Index(t => t.SealCategory_Id_Code)
                .Index(t => t.SealMakingUnitInfor_Id_MakingUnitCode)
                .Index(t => t.SealUseUnitInfor_Id_UnitNumber)
                .Index(t => t.SealState_Id_Code)
                .Index(t => t.SealApprovalUnitInfor_Id_ApprovalUnitCode);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AddSeals", "SealMaterial_Id_Code", "dbo.SealMaterials");
            DropForeignKey("dbo.AddSeals", "SealInforNew_Id", "dbo.SealInforNews");
            DropForeignKey("dbo.SealInforNews", "SealUseUnitInfor_Id_UnitNumber", "dbo.SealUseUnitInfors");
            DropForeignKey("dbo.SealInforNews", "SealState_Id_Code", "dbo.SealStates");
            DropForeignKey("dbo.SealInforNews", "SealMakingUnitInfor_Id_MakingUnitCode", "dbo.SealMakingUnitInfors");
            DropForeignKey("dbo.SealInforNews", "SealCategory_Id_Code", "dbo.SealCategories");
            DropForeignKey("dbo.SealInforNews", "SealApprovalUnitInfor_Id_ApprovalUnitCode", "dbo.SealApprovalUnitInfors");
            DropIndex("dbo.SealInforNews", new[] { "SealApprovalUnitInfor_Id_ApprovalUnitCode" });
            DropIndex("dbo.SealInforNews", new[] { "SealState_Id_Code" });
            DropIndex("dbo.SealInforNews", new[] { "SealUseUnitInfor_Id_UnitNumber" });
            DropIndex("dbo.SealInforNews", new[] { "SealMakingUnitInfor_Id_MakingUnitCode" });
            DropIndex("dbo.SealInforNews", new[] { "SealCategory_Id_Code" });
            DropIndex("dbo.AddSeals", new[] { "SealInforNew_Id" });
            DropIndex("dbo.AddSeals", new[] { "SealMaterial_Id_Code" });
            DropTable("dbo.SealInforNews");
            DropTable("dbo.AddSeals");
        }
    }
}
