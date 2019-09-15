namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _0011 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.DataFiles", newName: "DataToFiles");
            RenameTable(name: "dbo.FileAndImages", newName: "DataToImages");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.DataToImages", newName: "FileAndImages");
            RenameTable(name: "dbo.DataToFiles", newName: "DataFiles");
        }
    }
}
