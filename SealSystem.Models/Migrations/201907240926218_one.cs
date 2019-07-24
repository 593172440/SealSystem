namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class one : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EngravingLevels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EngravingTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Enterpises",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EnterpiseNumber = c.String(),
                        Name = c.String(nullable: false),
                        NationalCharacters = c.String(),
                        EnglishName = c.String(),
                        LegelPerson = c.String(nullable: false),
                        IdNumber = c.String(nullable: false, maxLength: 18),
                        LegelPhone = c.String(nullable: false),
                        EnterpriseDocuments = c.String(nullable: false),
                        EnterpriseAddress = c.String(nullable: false),
                        Remark = c.String(),
                        EnterpriseType_Id = c.Int(nullable: false),
                        EnterpriseClass_Id = c.Int(nullable: false),
                        EnterpriseDocumentsType_Id = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EnterpriseClasses", t => t.EnterpriseClass_Id)
                .ForeignKey("dbo.EnterpriseDocumentsTypes", t => t.EnterpriseDocumentsType_Id)
                .ForeignKey("dbo.EnterpriseTypes", t => t.EnterpriseType_Id)
                .Index(t => t.EnterpriseType_Id)
                .Index(t => t.EnterpriseClass_Id)
                .Index(t => t.EnterpriseDocumentsType_Id);
            
            CreateTable(
                "dbo.EnterpriseClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EnterpriseDocumentsTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EnterpriseTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Handlers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        IdNumber = c.String(nullable: false, maxLength: 18),
                        RecorderName = c.String(maxLength: 50),
                        RecordDate = c.DateTime(nullable: false),
                        RecordOrg = c.String(),
                        DeliveryMode = c.String(),
                        Remark = c.String(),
                        KeepRecord_Id = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.KeepRecords", t => t.KeepRecord_Id)
                .Index(t => t.KeepRecord_Id);
            
            CreateTable(
                "dbo.KeepRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KeepRecordType_Id = c.Int(nullable: false),
                        User_Id = c.Int(nullable: false),
                        Enterpise_Id = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                        Enterpise_Id1 = c.Int(),
                        KeepRecordType_Id1 = c.Int(),
                        User_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Enterpises", t => t.Enterpise_Id1)
                .ForeignKey("dbo.KeepRecordTypes", t => t.KeepRecordType_Id1)
                .ForeignKey("dbo.Users", t => t.User_Id1)
                .Index(t => t.Enterpise_Id1)
                .Index(t => t.KeepRecordType_Id1)
                .Index(t => t.User_Id1);
            
            CreateTable(
                "dbo.KeepRecordTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
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
            
            CreateTable(
                "dbo.RegistrationClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
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
                        SealContent = c.String(),
                        SealOtherContent = c.String(),
                        Remark = c.String(),
                        SealShape_Id = c.Int(nullable: false),
                        Enterpise_EnterpiseNumber_Id = c.Int(nullable: false),
                        SealMaterial_Id = c.Int(nullable: false),
                        EngravingType_Id = c.Int(nullable: false),
                        EngravingLevel_Id = c.Int(nullable: false),
                        RegistrationClass_Id = c.Int(nullable: false),
                        KeepRecord_Id = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EngravingLevels", t => t.EngravingLevel_Id)
                .ForeignKey("dbo.EngravingTypes", t => t.EngravingType_Id)
                .ForeignKey("dbo.Enterpises", t => t.Enterpise_EnterpiseNumber_Id)
                .ForeignKey("dbo.KeepRecords", t => t.KeepRecord_Id)
                .ForeignKey("dbo.RegistrationClasses", t => t.RegistrationClass_Id)
                .ForeignKey("dbo.SealMaterials", t => t.SealMaterial_Id)
                .ForeignKey("dbo.SealShapes", t => t.SealShape_Id)
                .Index(t => t.SealShape_Id)
                .Index(t => t.Enterpise_EnterpiseNumber_Id)
                .Index(t => t.SealMaterial_Id)
                .Index(t => t.EngravingType_Id)
                .Index(t => t.EngravingLevel_Id)
                .Index(t => t.RegistrationClass_Id)
                .Index(t => t.KeepRecord_Id);
            
            CreateTable(
                "dbo.SealMaterials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SealShapes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SealSpecifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        SealType_Id = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SealTypes", t => t.SealType_Id)
                .Index(t => t.SealType_Id);
            
            CreateTable(
                "dbo.SealTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Code = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SealSpecifications", "SealType_Id", "dbo.SealTypes");
            DropForeignKey("dbo.SealInfors", "SealShape_Id", "dbo.SealShapes");
            DropForeignKey("dbo.SealInfors", "SealMaterial_Id", "dbo.SealMaterials");
            DropForeignKey("dbo.SealInfors", "RegistrationClass_Id", "dbo.RegistrationClasses");
            DropForeignKey("dbo.SealInfors", "KeepRecord_Id", "dbo.KeepRecords");
            DropForeignKey("dbo.SealInfors", "Enterpise_EnterpiseNumber_Id", "dbo.Enterpises");
            DropForeignKey("dbo.SealInfors", "EngravingType_Id", "dbo.EngravingTypes");
            DropForeignKey("dbo.SealInfors", "EngravingLevel_Id", "dbo.EngravingLevels");
            DropForeignKey("dbo.Handlers", "KeepRecord_Id", "dbo.KeepRecords");
            DropForeignKey("dbo.KeepRecords", "User_Id1", "dbo.Users");
            DropForeignKey("dbo.KeepRecords", "KeepRecordType_Id1", "dbo.KeepRecordTypes");
            DropForeignKey("dbo.KeepRecords", "Enterpise_Id1", "dbo.Enterpises");
            DropForeignKey("dbo.Enterpises", "EnterpriseType_Id", "dbo.EnterpriseTypes");
            DropForeignKey("dbo.Enterpises", "EnterpriseDocumentsType_Id", "dbo.EnterpriseDocumentsTypes");
            DropForeignKey("dbo.Enterpises", "EnterpriseClass_Id", "dbo.EnterpriseClasses");
            DropIndex("dbo.SealSpecifications", new[] { "SealType_Id" });
            DropIndex("dbo.SealInfors", new[] { "KeepRecord_Id" });
            DropIndex("dbo.SealInfors", new[] { "RegistrationClass_Id" });
            DropIndex("dbo.SealInfors", new[] { "EngravingLevel_Id" });
            DropIndex("dbo.SealInfors", new[] { "EngravingType_Id" });
            DropIndex("dbo.SealInfors", new[] { "SealMaterial_Id" });
            DropIndex("dbo.SealInfors", new[] { "Enterpise_EnterpiseNumber_Id" });
            DropIndex("dbo.SealInfors", new[] { "SealShape_Id" });
            DropIndex("dbo.KeepRecords", new[] { "User_Id1" });
            DropIndex("dbo.KeepRecords", new[] { "KeepRecordType_Id1" });
            DropIndex("dbo.KeepRecords", new[] { "Enterpise_Id1" });
            DropIndex("dbo.Handlers", new[] { "KeepRecord_Id" });
            DropIndex("dbo.Enterpises", new[] { "EnterpriseDocumentsType_Id" });
            DropIndex("dbo.Enterpises", new[] { "EnterpriseClass_Id" });
            DropIndex("dbo.Enterpises", new[] { "EnterpriseType_Id" });
            DropTable("dbo.SealTypes");
            DropTable("dbo.SealSpecifications");
            DropTable("dbo.SealShapes");
            DropTable("dbo.SealMaterials");
            DropTable("dbo.SealInfors");
            DropTable("dbo.RegistrationClasses");
            DropTable("dbo.Users");
            DropTable("dbo.KeepRecordTypes");
            DropTable("dbo.KeepRecords");
            DropTable("dbo.Handlers");
            DropTable("dbo.EnterpriseTypes");
            DropTable("dbo.EnterpriseDocumentsTypes");
            DropTable("dbo.EnterpriseClasses");
            DropTable("dbo.Enterpises");
            DropTable("dbo.EngravingTypes");
            DropTable("dbo.EngravingLevels");
        }
    }
}
