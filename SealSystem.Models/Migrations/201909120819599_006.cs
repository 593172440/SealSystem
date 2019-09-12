namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _006 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SealInforNews", "TheOrders_TheOrderCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SealInforNews", "TheOrders_TheOrderCode");
        }
    }
}
