namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _013 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "UnitCode", c => c.String());
            AddColumn("dbo.Users", "Note", c => c.String());
            AddColumn("dbo.Users", "EthnicMinoritiesName", c => c.String());
            AddColumn("dbo.Users", "EnglishName", c => c.String());
            AddColumn("dbo.Users", "LegelPerson", c => c.String());
            AddColumn("dbo.Users", "IdNumber", c => c.String(maxLength: 18));
            AddColumn("dbo.Users", "UnitAddress", c => c.String());
            AddColumn("dbo.Users", "Phone", c => c.String());
            AddColumn("dbo.Users", "TheZipCode", c => c.String());
            AddColumn("dbo.Users", "Contact", c => c.String());
            AddColumn("dbo.Users", "ContanctPhone", c => c.String());
            AddColumn("dbo.Users", "BusinessLicense", c => c.String());
            AddColumn("dbo.Users", "BusinessState", c => c.String());
            AddColumn("dbo.Users", "Attention", c => c.String());
            AddColumn("dbo.Users", "AttentionIdCard", c => c.String());
            AddColumn("dbo.Users", "Approval", c => c.String());
            AlterColumn("dbo.Users", "EntityName", c => c.String());
            DropTable("dbo.SealApprovalUnitInfors");
            DropTable("dbo.SealMakingUnitInfors");
        }
        
        public override void Down()
        {
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
                "dbo.SealApprovalUnitInfors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApprovalUnitCode = c.String(),
                        Name = c.String(),
                        Attention = c.String(),
                        AttentionIdCard = c.String(),
                        Contact = c.String(),
                        Approval = c.String(),
                        Note = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.Users", "EntityName", c => c.String(nullable: false));
            DropColumn("dbo.Users", "Approval");
            DropColumn("dbo.Users", "AttentionIdCard");
            DropColumn("dbo.Users", "Attention");
            DropColumn("dbo.Users", "BusinessState");
            DropColumn("dbo.Users", "BusinessLicense");
            DropColumn("dbo.Users", "ContanctPhone");
            DropColumn("dbo.Users", "Contact");
            DropColumn("dbo.Users", "TheZipCode");
            DropColumn("dbo.Users", "Phone");
            DropColumn("dbo.Users", "UnitAddress");
            DropColumn("dbo.Users", "IdNumber");
            DropColumn("dbo.Users", "LegelPerson");
            DropColumn("dbo.Users", "EnglishName");
            DropColumn("dbo.Users", "EthnicMinoritiesName");
            DropColumn("dbo.Users", "Note");
            DropColumn("dbo.Users", "UnitCode");
        }
    }
}
