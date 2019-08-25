namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _007 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.SealMaterials", newName: "SealSystemLists");
            DropForeignKey("dbo.SealInforNews", "SealMaterial_Id_Code", "dbo.SealMaterials");
            DropIndex("dbo.SealInforNews", new[] { "SealMaterial_Id_Code" });
            AddColumn("dbo.SealInforNews", "SealMaterial", c => c.String());
            AddColumn("dbo.SealSystemLists", "Types", c => c.String());
            AddColumn("dbo.SealSystemLists", "Note", c => c.String());
            DropColumn("dbo.SealInforNews", "SealMaterial_Id_Code");
            DropTable("dbo.SealUseUnitInforLists");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SealUseUnitInforLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Types = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.SealInforNews", "SealMaterial_Id_Code", c => c.Int(nullable: false));
            DropColumn("dbo.SealSystemLists", "Note");
            DropColumn("dbo.SealSystemLists", "Types");
            DropColumn("dbo.SealInforNews", "SealMaterial");
            CreateIndex("dbo.SealInforNews", "SealMaterial_Id_Code");
            AddForeignKey("dbo.SealInforNews", "SealMaterial_Id_Code", "dbo.SealMaterials", "Id");
            RenameTable(name: "dbo.SealSystemLists", newName: "SealMaterials");
        }
    }
}
