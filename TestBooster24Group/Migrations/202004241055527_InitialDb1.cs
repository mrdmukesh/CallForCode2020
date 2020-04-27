namespace ClinicManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDb1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TestBoosetr24Group",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Token = c.String(),
                        Name = c.String(),
                        GroupOwnerId = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        Address = c.String(),
                        CityId = c.Byte(nullable: false),
                        TestStatus = c.Int(nullable: false),
                        Doctor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
            AddColumn("dbo.Patients", "TestGroupId", c => c.Int());
            CreateIndex("dbo.Patients", "TestGroupId");
            AddForeignKey("dbo.Patients", "TestGroupId", "dbo.TestBoosetr24Group", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patients", "TestGroupId", "dbo.TestBoosetr24Group");
            DropForeignKey("dbo.TestBoosetr24Group", "CityId", "dbo.Cities");
            DropIndex("dbo.TestBoosetr24Group", new[] { "CityId" });
            DropIndex("dbo.Patients", new[] { "TestGroupId" });
            DropColumn("dbo.Patients", "TestGroupId");
            DropTable("dbo.TestBoosetr24Group");
        }
    }
}
