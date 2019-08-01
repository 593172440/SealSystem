namespace SealSystem.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _005 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.FileAndImages", name: "User_Id", newName: "SealInfor_Id");
            RenameIndex(table: "dbo.FileAndImages", name: "IX_User_Id", newName: "IX_SealInfor_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.FileAndImages", name: "IX_SealInfor_Id", newName: "IX_User_Id");
            RenameColumn(table: "dbo.FileAndImages", name: "SealInfor_Id", newName: "User_Id");
        }
    }
}
