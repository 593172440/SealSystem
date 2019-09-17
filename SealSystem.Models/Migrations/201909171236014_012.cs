namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _012 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TheOrders", "SealState", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TheOrders", "SealState");
        }
    }
}
