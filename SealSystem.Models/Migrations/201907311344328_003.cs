namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _003 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MenuTables", "Add", c => c.Boolean(nullable: false));
            AddColumn("dbo.MenuTables", "Edit", c => c.Boolean(nullable: false));
            AddColumn("dbo.MenuTables", "Details", c => c.Boolean(nullable: false));
            AddColumn("dbo.MenuTables", "Delete", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MenuTables", "Delete");
            DropColumn("dbo.MenuTables", "Details");
            DropColumn("dbo.MenuTables", "Edit");
            DropColumn("dbo.MenuTables", "Add");
        }
    }
}
