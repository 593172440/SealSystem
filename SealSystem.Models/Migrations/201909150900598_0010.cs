namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _0010 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DataFiles", "NamePath", c => c.String());
            AddColumn("dbo.DataFiles", "SealInforNew_SealInforNum", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DataFiles", "SealInforNew_SealInforNum");
            DropColumn("dbo.DataFiles", "NamePath");
        }
    }
}
