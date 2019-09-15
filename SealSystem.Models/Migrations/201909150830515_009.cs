namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _009 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SealCategories", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SealCategories", "Name", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
