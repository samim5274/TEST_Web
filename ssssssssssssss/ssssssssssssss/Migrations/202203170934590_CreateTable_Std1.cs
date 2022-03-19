namespace ssssssssssssss.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTable_Std1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Stds");
        }
    }
}
