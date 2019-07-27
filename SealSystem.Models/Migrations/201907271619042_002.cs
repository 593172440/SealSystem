namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _002 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SealMakingUnitInfors", "ContanctPhone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SealMakingUnitInfors", "ContanctPhone");
        }
    }
}
