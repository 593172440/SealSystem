namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _003 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MenuTables", "CodeId", c => c.Int(nullable: false));
            AddColumn("dbo.MenuTables", "SuperiorCodeId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MenuTables", "SuperiorCodeId");
            DropColumn("dbo.MenuTables", "CodeId");
        }
    }
}
