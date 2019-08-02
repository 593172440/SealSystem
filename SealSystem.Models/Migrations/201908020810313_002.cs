namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _002 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SealInforNews", "SealState", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SealInforNews", "SealState", c => c.Int(nullable: false));
        }
    }
}
