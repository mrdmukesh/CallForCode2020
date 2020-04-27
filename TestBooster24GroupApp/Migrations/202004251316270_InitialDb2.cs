namespace ClinicManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDb2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Patients", name: "TestBoosetr24Group_Id", newName: "TestGroup_Id");
            RenameIndex(table: "dbo.Patients", name: "IX_TestBoosetr24Group_Id", newName: "IX_TestGroup_Id");
            AddColumn("dbo.Patients", "TestGroupId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Patients", "TestGroupId");
            RenameIndex(table: "dbo.Patients", name: "IX_TestGroup_Id", newName: "IX_TestBoosetr24Group_Id");
            RenameColumn(table: "dbo.Patients", name: "TestGroup_Id", newName: "TestBoosetr24Group_Id");
        }
    }
}
