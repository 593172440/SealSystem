namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _002 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SealInforNews", "SealState_Id_Code", "dbo.SealStates");
            DropForeignKey("dbo.SealInfors", "SealState_Id_Code", "dbo.SealStates");
            DropIndex("dbo.SealInforNews", new[] { "SealState_Id_Code" });
            DropIndex("dbo.SealInfors", new[] { "SealState_Id_Code" });
            AddColumn("dbo.SealInforNews", "SealState", c => c.Int(nullable: false));
            AddColumn("dbo.SealInfors", "SealState", c => c.String());
            DropColumn("dbo.SealInforNews", "SealState_Id_Code");
            DropColumn("dbo.SealInfors", "SealState_Id_Code");
            DropTable("dbo.SealStates");
        }
        
        public override void Down()
        {
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
            
            AddColumn("dbo.SealInfors", "SealState_Id_Code", c => c.Int(nullable: false));
            AddColumn("dbo.SealInforNews", "SealState_Id_Code", c => c.Int(nullable: false));
            DropColumn("dbo.SealInfors", "SealState");
            DropColumn("dbo.SealInforNews", "SealState");
            CreateIndex("dbo.SealInfors", "SealState_Id_Code");
            CreateIndex("dbo.SealInforNews", "SealState_Id_Code");
            AddForeignKey("dbo.SealInfors", "SealState_Id_Code", "dbo.SealStates", "Id");
            AddForeignKey("dbo.SealInforNews", "SealState_Id_Code", "dbo.SealStates", "Id");
        }
    }
}
