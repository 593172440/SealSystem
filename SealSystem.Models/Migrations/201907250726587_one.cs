namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class one : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SealUnitClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SealApprovalUnitInfors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApprovalUnitCode = c.String(),
                        Name = c.String(nullable: false),
                        LegelPerson = c.String(),
                        UnitAddress = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        TheZipCode = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SealCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Code = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SealImageDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImageWidth = c.String(),
                        ImageHeight = c.String(),
                        CompressTag = c.String(),
                        ImageDataPath = c.String(),
                        SealSpecification = c.Int(nullable: false),
                        SealShape = c.String(),
                        EngravingType = c.String(),
                        EngravingLevel = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SealInfors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SealInforNum = c.Int(nullable: false),
                        SealName = c.Int(nullable: false),
                        SealState_Id_Code = c.Int(nullable: false),
                        SealUseUnitInfor_Id_UnitNumber = c.Int(nullable: false),
                        SealApprovalUnitInfor_Id_ApprovalUnitCode = c.Int(nullable: false),
                        SealMakingUnitInfor_Id_MakingUnitCode = c.Int(nullable: false),
                        SealCategory_Id_Code = c.Int(nullable: false),
                        SealMaterial_Id_Code = c.Int(nullable: false),
                        ManyInstructions = c.String(),
                        Attention = c.String(),
                        AttentionIdCard = c.String(),
                        Approval = c.String(),
                        ApprovalTime = c.DateTime(nullable: false),
                        UndertakeTime = c.DateTime(nullable: false),
                        MakingTime = c.DateTime(nullable: false),
                        DeliveryTime = c.DateTime(nullable: false),
                        ScrapTime = c.DateTime(nullable: false),
                        HandTime = c.DateTime(nullable: false),
                        LossTime = c.DateTime(nullable: false),
                        LastAnnualTime = c.DateTime(nullable: false),
                        SealImageData_Id = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SealApprovalUnitInfors", t => t.SealApprovalUnitInfor_Id_ApprovalUnitCode)
                .ForeignKey("dbo.SealCategories", t => t.SealCategory_Id_Code)
                .ForeignKey("dbo.SealImageDatas", t => t.SealImageData_Id)
                .ForeignKey("dbo.SealMakingUnitInfors", t => t.SealMakingUnitInfor_Id_MakingUnitCode)
                .ForeignKey("dbo.SealMaterials", t => t.SealMaterial_Id_Code)
                .ForeignKey("dbo.SealStates", t => t.SealState_Id_Code)
                .ForeignKey("dbo.SealUseUnitInfors", t => t.SealUseUnitInfor_Id_UnitNumber)
                .Index(t => t.SealState_Id_Code)
                .Index(t => t.SealUseUnitInfor_Id_UnitNumber)
                .Index(t => t.SealApprovalUnitInfor_Id_ApprovalUnitCode)
                .Index(t => t.SealMakingUnitInfor_Id_MakingUnitCode)
                .Index(t => t.SealCategory_Id_Code)
                .Index(t => t.SealMaterial_Id_Code)
                .Index(t => t.SealImageData_Id);
            
            CreateTable(
                "dbo.SealMakingUnitInfors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MakingUnitCode = c.String(),
                        Name = c.String(),
                        EthnicMinoritiesName = c.String(),
                        EnglishName = c.String(),
                        LegelPerson = c.String(nullable: false),
                        IdNumber = c.String(nullable: false, maxLength: 18),
                        UnitAddress = c.String(nullable: false),
                        Phone = c.String(),
                        TheZipCode = c.String(),
                        Contact = c.String(),
                        BusinessLicense = c.String(),
                        BusinessState = c.String(),
                        Remarks = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SealMaterials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SealStates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SealUseUnitInfors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UnitNumber = c.String(),
                        Name = c.String(nullable: false),
                        EthnicMinoritiesName = c.String(),
                        EnglishName = c.String(),
                        EnterpriseType_Id = c.Int(nullable: false),
                        VoiceQueryPassword = c.String(),
                        LegelPerson = c.String(nullable: false),
                        IdNumber = c.String(nullable: false, maxLength: 18),
                        UnitAddress = c.String(nullable: false),
                        Phone = c.String(),
                        TheZipCode = c.String(),
                        SealUnitClass_Id = c.Int(nullable: false),
                        EnterpriseDocumentsType = c.String(),
                        IdNumbers = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SealUnitCategories", t => t.EnterpriseType_Id)
                .ForeignKey("dbo.SealUnitClasses", t => t.SealUnitClass_Id)
                .Index(t => t.EnterpriseType_Id)
                .Index(t => t.SealUnitClass_Id);
            
            CreateTable(
                "dbo.SealUnitCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Code = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 50),
                        UserPwd = c.String(nullable: false, maxLength: 50),
                        EntityName = c.String(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SealInfors", "SealUseUnitInfor_Id_UnitNumber", "dbo.SealUseUnitInfors");
            DropForeignKey("dbo.SealUseUnitInfors", "SealUnitClass_Id", "dbo.SealUnitClasses");
            DropForeignKey("dbo.SealUseUnitInfors", "EnterpriseType_Id", "dbo.SealUnitCategories");
            DropForeignKey("dbo.SealInfors", "SealState_Id_Code", "dbo.SealStates");
            DropForeignKey("dbo.SealInfors", "SealMaterial_Id_Code", "dbo.SealMaterials");
            DropForeignKey("dbo.SealInfors", "SealMakingUnitInfor_Id_MakingUnitCode", "dbo.SealMakingUnitInfors");
            DropForeignKey("dbo.SealInfors", "SealImageData_Id", "dbo.SealImageDatas");
            DropForeignKey("dbo.SealInfors", "SealCategory_Id_Code", "dbo.SealCategories");
            DropForeignKey("dbo.SealInfors", "SealApprovalUnitInfor_Id_ApprovalUnitCode", "dbo.SealApprovalUnitInfors");
            DropIndex("dbo.SealUseUnitInfors", new[] { "SealUnitClass_Id" });
            DropIndex("dbo.SealUseUnitInfors", new[] { "EnterpriseType_Id" });
            DropIndex("dbo.SealInfors", new[] { "SealImageData_Id" });
            DropIndex("dbo.SealInfors", new[] { "SealMaterial_Id_Code" });
            DropIndex("dbo.SealInfors", new[] { "SealCategory_Id_Code" });
            DropIndex("dbo.SealInfors", new[] { "SealMakingUnitInfor_Id_MakingUnitCode" });
            DropIndex("dbo.SealInfors", new[] { "SealApprovalUnitInfor_Id_ApprovalUnitCode" });
            DropIndex("dbo.SealInfors", new[] { "SealUseUnitInfor_Id_UnitNumber" });
            DropIndex("dbo.SealInfors", new[] { "SealState_Id_Code" });
            DropTable("dbo.Users");
            DropTable("dbo.SealUnitCategories");
            DropTable("dbo.SealUseUnitInfors");
            DropTable("dbo.SealStates");
            DropTable("dbo.SealMaterials");
            DropTable("dbo.SealMakingUnitInfors");
            DropTable("dbo.SealInfors");
            DropTable("dbo.SealImageDatas");
            DropTable("dbo.SealCategories");
            DropTable("dbo.SealApprovalUnitInfors");
            DropTable("dbo.SealUnitClasses");
        }
    }
}
