namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _005 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TheOrders", "TheOrderCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TheOrders", "TheOrderCode");
        }
    }
}
