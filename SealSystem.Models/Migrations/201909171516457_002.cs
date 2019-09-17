namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _002 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserPermissions", "Menu_Id", "dbo.MenuTables");
            DropIndex("dbo.UserPermissions", new[] { "Menu_Id" });
            AddColumn("dbo.UserPermissions", "MenuTables_CodeId", c => c.Int(nullable: false));
            AlterColumn("dbo.SealInforNews", "User_Id", c => c.Int(nullable: false));
            DropColumn("dbo.UserPermissions", "Menu_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserPermissions", "Menu_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.SealInforNews", "User_Id", c => c.String());
            DropColumn("dbo.UserPermissions", "MenuTables_CodeId");
            CreateIndex("dbo.UserPermissions", "Menu_Id");
            AddForeignKey("dbo.UserPermissions", "Menu_Id", "dbo.MenuTables", "Id");
        }
    }
}
