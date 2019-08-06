namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _00 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SealSpecifications", "SealCategory_Id", "dbo.SealCategories");
            DropIndex("dbo.SealSpecifications", new[] { "SealCategory_Id" });
            AddColumn("dbo.SealCategories", "SealSpecifications", c => c.String());
            AddColumn("dbo.SealCategories", "TestImagePath", c => c.String());
            DropTable("dbo.SealSpecifications");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SealSpecifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SealSpecifications = c.String(),
                        TestImagePath = c.String(),
                        SealCategory_Id = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.SealCategories", "TestImagePath");
            DropColumn("dbo.SealCategories", "SealSpecifications");
            CreateIndex("dbo.SealSpecifications", "SealCategory_Id");
            AddForeignKey("dbo.SealSpecifications", "SealCategory_Id", "dbo.SealCategories", "Id");
        }
    }
}
