namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _003 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SealInforNews", "SealSpecification");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SealInforNews", "SealSpecification", c => c.String());
        }
    }
}
