namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _004 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SealInfors", "SealInforNum", c => c.String(nullable: false));
            AlterColumn("dbo.SealInfors", "SealName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SealInfors", "SealName", c => c.Int(nullable: false));
            AlterColumn("dbo.SealInfors", "SealInforNum", c => c.Int(nullable: false));
        }
    }
}
