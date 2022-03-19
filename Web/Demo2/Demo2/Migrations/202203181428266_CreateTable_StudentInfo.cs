namespace Demo2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTable_StudentInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        Roll = c.String(),
                        Registation = c.String(),
                        DateOfBirth = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentInfoes");
        }
    }
}
