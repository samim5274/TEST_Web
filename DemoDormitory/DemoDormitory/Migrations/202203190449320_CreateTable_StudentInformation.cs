namespace DemoDormitory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTable_StudentInformation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentInformations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentInformations");
        }
    }
}
