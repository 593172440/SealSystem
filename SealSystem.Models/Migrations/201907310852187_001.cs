namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _001 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MenuTables", "MenuPath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MenuTables", "MenuPath");
        }
    }
}
