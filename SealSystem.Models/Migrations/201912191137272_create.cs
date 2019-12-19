namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create : DbMigration
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
                "dbo.DataToFiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FileInstructions = c.String(),
                        NamePath = c.String(),
                        SealInforNew_SealInforNum = c.String(),
                        Note = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DataToImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NamePath = c.String(),
                        SealInforNew_SealInforNum = c.String(),
                        Note = c.String(),
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
                "dbo.SealCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        SealSpecifications = c.String(),
                        TestImagePath = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SealInforNews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SealInforNum = c.String(nullable: false),
                        SealUseUnitInfor_Id_UnitNumber = c.Int(nullable: false),
                        TheOrders_TheOrderCode = c.String(),
                        User_Id = c.Int(nullable: false),
                        SealCategory_Id_Code = c.Int(nullable: false),
                        SealContent = c.String(),
                        ForeignLanguageContent = c.String(),
                        SealMaterial = c.String(),
                        RegistrationCategory = c.String(),
                        SealShape = c.String(),
                        EngravingType = c.String(),
                        EngravingLevel = c.String(),
                        SealState = c.String(),
                        MakeWay = c.String(),
                        TheProducer = c.String(),
                        Note = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SealCategories", t => t.SealCategory_Id_Code)
                .ForeignKey("dbo.SealUseUnitInfors", t => t.SealUseUnitInfor_Id_UnitNumber)
                .Index(t => t.SealUseUnitInfor_Id_UnitNumber)
                .Index(t => t.SealCategory_Id_Code);
            
            CreateTable(
                "dbo.SealUseUnitInfors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UnitNumber = c.String(),
                        Name = c.String(nullable: false),
                        EthnicMinoritiesName = c.String(),
                        EnglishName = c.String(),
                        LegelPerson = c.String(nullable: false),
                        IdNumber = c.String(nullable: false, maxLength: 18),
                        UnitAddress = c.String(nullable: false),
                        Phone = c.String(),
                        IdNumbers = c.String(),
                        Note = c.String(),
                        UnitClassification = c.String(),
                        EnterpriseDocumentsType = c.String(),
                        TheUnitType = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SealSystemLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Types = c.String(),
                        Note = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TheOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TheOrderCode = c.String(),
                        TheRegistrationArea = c.String(),
                        SealMakingUnitInfor_Name = c.String(),
                        ForTheRecordType = c.String(),
                        TakeSealName = c.String(),
                        TakeTime = c.DateTime(),
                        IdCard = c.String(),
                        Phone = c.String(),
                        DeliveryTime = c.DateTime(),
                        UpTime = c.DateTime(),
                        SealState = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserPermissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserGroup_Id = c.Int(nullable: false),
                        MenuTables_CodeId = c.Int(nullable: false),
                        Add = c.Boolean(nullable: false),
                        Edit = c.Boolean(nullable: false),
                        Details = c.Boolean(nullable: false),
                        Delete = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserGroups", t => t.UserGroup_Id)
                .Index(t => t.UserGroup_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 50),
                        UserPwd = c.String(nullable: false, maxLength: 50),
                        EntityName = c.String(),
                        UnitCode = c.String(),
                        Note = c.String(),
                        UserGroup_Id = c.Int(nullable: false),
                        EthnicMinoritiesName = c.String(),
                        EnglishName = c.String(),
                        LegelPerson = c.String(),
                        IdNumber = c.String(maxLength: 18),
                        UnitAddress = c.String(),
                        Phone = c.String(),
                        TheZipCode = c.String(),
                        Contact = c.String(),
                        ContanctPhone = c.String(),
                        BusinessLicense = c.String(),
                        BusinessState = c.String(),
                        Attention = c.String(),
                        AttentionIdCard = c.String(),
                        Approval = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserGroups", t => t.UserGroup_Id)
                .Index(t => t.UserGroup_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "UserGroup_Id", "dbo.UserGroups");
            DropForeignKey("dbo.UserPermissions", "UserGroup_Id", "dbo.UserGroups");
            DropForeignKey("dbo.SealInforNews", "SealUseUnitInfor_Id_UnitNumber", "dbo.SealUseUnitInfors");
            DropForeignKey("dbo.SealInforNews", "SealCategory_Id_Code", "dbo.SealCategories");
            DropIndex("dbo.Users", new[] { "UserGroup_Id" });
            DropIndex("dbo.UserPermissions", new[] { "UserGroup_Id" });
            DropIndex("dbo.SealInforNews", new[] { "SealCategory_Id_Code" });
            DropIndex("dbo.SealInforNews", new[] { "SealUseUnitInfor_Id_UnitNumber" });
            DropTable("dbo.Users");
            DropTable("dbo.UserPermissions");
            DropTable("dbo.UserGroups");
            DropTable("dbo.TheOrders");
            DropTable("dbo.SealSystemLists");
            DropTable("dbo.SealUseUnitInfors");
            DropTable("dbo.SealInforNews");
            DropTable("dbo.SealCategories");
            DropTable("dbo.MenuTables");
            DropTable("dbo.DataToImages");
            DropTable("dbo.DataToFiles");
            DropTable("dbo.Areas");
            DropTable("dbo.AnnouncementNotices");
        }
    }
}
