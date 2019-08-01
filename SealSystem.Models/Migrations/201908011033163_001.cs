namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AnnouncementNotices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        UserName = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DataFiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FileInstructions = c.String(),
                        Note = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FileAndImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NamePath = c.String(),
                        SealInfor_Id = c.Int(),
                        Note = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SealInfors", t => t.SealInfor_Id)
                .Index(t => t.SealInfor_Id);
            
            CreateTable(
                "dbo.SealInfors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SealInforNum = c.String(nullable: false),
                        SealName = c.String(),
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
                        ApprovalTime = c.DateTime(),
                        UndertakeTime = c.DateTime(),
                        MakingTime = c.DateTime(),
                        DeliveryTime = c.DateTime(),
                        ScrapTime = c.DateTime(),
                        HandTime = c.DateTime(),
                        LossTime = c.DateTime(),
                        LastAnnualTime = c.DateTime(),
                        ImageWidth = c.String(),
                        ImageHeight = c.String(),
                        CompressTag = c.String(),
                        ImageDataPath = c.String(),
                        SealSpecification = c.String(),
                        SealShape = c.String(),
                        EngravingType = c.String(),
                        EngravingLevel = c.String(),
                        RegistrationCategory = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SealApprovalUnitInfors", t => t.SealApprovalUnitInfor_Id_ApprovalUnitCode)
                .ForeignKey("dbo.SealCategories", t => t.SealCategory_Id_Code)
                .ForeignKey("dbo.SealMakingUnitInfors", t => t.SealMakingUnitInfor_Id_MakingUnitCode)
                .ForeignKey("dbo.SealMaterials", t => t.SealMaterial_Id_Code)
                .ForeignKey("dbo.SealStates", t => t.SealState_Id_Code)
                .ForeignKey("dbo.SealUseUnitInfors", t => t.SealUseUnitInfor_Id_UnitNumber)
                .Index(t => t.SealState_Id_Code)
                .Index(t => t.SealUseUnitInfor_Id_UnitNumber)
                .Index(t => t.SealApprovalUnitInfor_Id_ApprovalUnitCode)
                .Index(t => t.SealMakingUnitInfor_Id_MakingUnitCode)
                .Index(t => t.SealCategory_Id_Code)
                .Index(t => t.SealMaterial_Id_Code);
            
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
                        ContanctPhone = c.String(),
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
                        Area_Id = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Areas", t => t.Area_Id)
                .ForeignKey("dbo.SealUnitCategories", t => t.EnterpriseType_Id)
                .ForeignKey("dbo.SealUnitClasses", t => t.SealUnitClass_Id)
                .Index(t => t.EnterpriseType_Id)
                .Index(t => t.SealUnitClass_Id)
                .Index(t => t.Area_Id);
            
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
                "dbo.MenuTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodeId = c.Int(nullable: false),
                        Name = c.String(),
                        SuperiorCodeId = c.Int(nullable: false),
                        MenuPath = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserPermissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User_Id = c.Int(nullable: false),
                        Menu_Id = c.Int(nullable: false),
                        Add = c.Boolean(nullable: false),
                        Edit = c.Boolean(nullable: false),
                        Details = c.Boolean(nullable: false),
                        Delete = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MenuTables", t => t.Menu_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id)
                .Index(t => t.Menu_Id);
            
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
            DropForeignKey("dbo.UserPermissions", "User_Id", "dbo.Users");
            DropForeignKey("dbo.UserPermissions", "Menu_Id", "dbo.MenuTables");
            DropForeignKey("dbo.FileAndImages", "SealInfor_Id", "dbo.SealInfors");
            DropForeignKey("dbo.SealInfors", "SealUseUnitInfor_Id_UnitNumber", "dbo.SealUseUnitInfors");
            DropForeignKey("dbo.SealUseUnitInfors", "SealUnitClass_Id", "dbo.SealUnitClasses");
            DropForeignKey("dbo.SealUseUnitInfors", "EnterpriseType_Id", "dbo.SealUnitCategories");
            DropForeignKey("dbo.SealUseUnitInfors", "Area_Id", "dbo.Areas");
            DropForeignKey("dbo.SealInfors", "SealState_Id_Code", "dbo.SealStates");
            DropForeignKey("dbo.SealInfors", "SealMaterial_Id_Code", "dbo.SealMaterials");
            DropForeignKey("dbo.SealInfors", "SealMakingUnitInfor_Id_MakingUnitCode", "dbo.SealMakingUnitInfors");
            DropForeignKey("dbo.SealInfors", "SealCategory_Id_Code", "dbo.SealCategories");
            DropForeignKey("dbo.SealInfors", "SealApprovalUnitInfor_Id_ApprovalUnitCode", "dbo.SealApprovalUnitInfors");
            DropIndex("dbo.UserPermissions", new[] { "Menu_Id" });
            DropIndex("dbo.UserPermissions", new[] { "User_Id" });
            DropIndex("dbo.SealUseUnitInfors", new[] { "Area_Id" });
            DropIndex("dbo.SealUseUnitInfors", new[] { "SealUnitClass_Id" });
            DropIndex("dbo.SealUseUnitInfors", new[] { "EnterpriseType_Id" });
            DropIndex("dbo.SealInfors", new[] { "SealMaterial_Id_Code" });
            DropIndex("dbo.SealInfors", new[] { "SealCategory_Id_Code" });
            DropIndex("dbo.SealInfors", new[] { "SealMakingUnitInfor_Id_MakingUnitCode" });
            DropIndex("dbo.SealInfors", new[] { "SealApprovalUnitInfor_Id_ApprovalUnitCode" });
            DropIndex("dbo.SealInfors", new[] { "SealUseUnitInfor_Id_UnitNumber" });
            DropIndex("dbo.SealInfors", new[] { "SealState_Id_Code" });
            DropIndex("dbo.FileAndImages", new[] { "SealInfor_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.UserPermissions");
            DropTable("dbo.MenuTables");
            DropTable("dbo.SealUnitClasses");
            DropTable("dbo.SealUnitCategories");
            DropTable("dbo.SealUseUnitInfors");
            DropTable("dbo.SealStates");
            DropTable("dbo.SealMaterials");
            DropTable("dbo.SealMakingUnitInfors");
            DropTable("dbo.SealCategories");
            DropTable("dbo.SealApprovalUnitInfors");
            DropTable("dbo.SealInfors");
            DropTable("dbo.FileAndImages");
            DropTable("dbo.DataFiles");
            DropTable("dbo.Areas");
            DropTable("dbo.AnnouncementNotices");
        }
    }
}
