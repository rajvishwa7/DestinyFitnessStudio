namespace DestinyFitnessStudioCrudEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSetUp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Memberships",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Mobile = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                        Height = c.String(),
                        Weight = c.String(),
                        City = c.String(),
                        FitProgram = c.String(),
                        Fees = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Memberships");
        }
    }
}
