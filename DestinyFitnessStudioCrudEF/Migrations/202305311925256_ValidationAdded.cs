namespace DestinyFitnessStudioCrudEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ValidationAdded : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Memberships", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Memberships", "Mobile", c => c.String(nullable: false));
            AlterColumn("dbo.Memberships", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Memberships", "Gender", c => c.String(nullable: false));
            AlterColumn("dbo.Memberships", "Height", c => c.String(nullable: false));
            AlterColumn("dbo.Memberships", "Weight", c => c.String(nullable: false));
            AlterColumn("dbo.Memberships", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Memberships", "FitProgram", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Memberships", "FitProgram", c => c.String());
            AlterColumn("dbo.Memberships", "City", c => c.String());
            AlterColumn("dbo.Memberships", "Weight", c => c.String());
            AlterColumn("dbo.Memberships", "Height", c => c.String());
            AlterColumn("dbo.Memberships", "Gender", c => c.String());
            AlterColumn("dbo.Memberships", "Email", c => c.String());
            AlterColumn("dbo.Memberships", "Mobile", c => c.String());
            AlterColumn("dbo.Memberships", "Name", c => c.String());
        }
    }
}
