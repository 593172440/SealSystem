namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _003 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SealImageDatas", "SealSpecification", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SealImageDatas", "SealSpecification", c => c.Int(nullable: false));
        }
    }
}
