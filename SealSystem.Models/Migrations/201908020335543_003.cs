namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _003 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AddSeals", "SealInforNew_Id", "dbo.SealInforNews");
            DropForeignKey("dbo.AddSeals", "SealMaterial_Id_Code", "dbo.SealMaterials");
            DropIndex("dbo.AddSeals", new[] { "SealMaterial_Id_Code" });
            DropIndex("dbo.AddSeals", new[] { "SealInforNew_Id" });
            AddColumn("dbo.SealInforNews", "SealInforNum", c => c.String(nullable: false));
            AddColumn("dbo.SealInforNews", "ForeignLanguageContent", c => c.String());
            AddColumn("dbo.SealInforNews", "SealMaterial_Id_Code", c => c.Int(nullable: false));
            AddColumn("dbo.SealInforNews", "MakeWay", c => c.String());
            AddColumn("dbo.SealInforNews", "TheProducer", c => c.String());
            CreateIndex("dbo.SealInforNews", "SealMaterial_Id_Code");
            AddForeignKey("dbo.SealInforNews", "SealMaterial_Id_Code", "dbo.SealMaterials", "Id");
            DropTable("dbo.AddSeals");
        }
        
        public override void Down()
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
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.SealInforNews", "SealMaterial_Id_Code", "dbo.SealMaterials");
            DropIndex("dbo.SealInforNews", new[] { "SealMaterial_Id_Code" });
            DropColumn("dbo.SealInforNews", "TheProducer");
            DropColumn("dbo.SealInforNews", "MakeWay");
            DropColumn("dbo.SealInforNews", "SealMaterial_Id_Code");
            DropColumn("dbo.SealInforNews", "ForeignLanguageContent");
            DropColumn("dbo.SealInforNews", "SealInforNum");
            CreateIndex("dbo.AddSeals", "SealInforNew_Id");
            CreateIndex("dbo.AddSeals", "SealMaterial_Id_Code");
            AddForeignKey("dbo.AddSeals", "SealMaterial_Id_Code", "dbo.SealMaterials", "Id");
            AddForeignKey("dbo.AddSeals", "SealInforNew_Id", "dbo.SealInforNews", "Id");
        }
    }
}
