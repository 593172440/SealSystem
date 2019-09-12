namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _007 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.TheOrders", "SealInforNum");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TheOrders", "SealInforNum", c => c.String());
        }
    }
}
