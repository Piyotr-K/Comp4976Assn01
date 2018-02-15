namespace LmycWebSite.Migrations.LmycMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedUserModel : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Boats", name: "AspNetUser_Id", newName: "CreatedBy_Id");
            RenameIndex(table: "dbo.Boats", name: "IX_AspNetUser_Id", newName: "IX_CreatedBy_Id");
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "AddressStreet", c => c.String());
            AddColumn("dbo.AspNetUsers", "AddressCity", c => c.String());
            AddColumn("dbo.AspNetUsers", "AddressProv", c => c.String());
            AddColumn("dbo.AspNetUsers", "AddressZipCode", c => c.String());
            AddColumn("dbo.AspNetUsers", "AddressCountry", c => c.String());
            AddColumn("dbo.AspNetUsers", "MobileNumber", c => c.String());
            AddColumn("dbo.AspNetUsers", "SailingExperience", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "SailingExperience");
            DropColumn("dbo.AspNetUsers", "MobileNumber");
            DropColumn("dbo.AspNetUsers", "AddressCountry");
            DropColumn("dbo.AspNetUsers", "AddressZipCode");
            DropColumn("dbo.AspNetUsers", "AddressProv");
            DropColumn("dbo.AspNetUsers", "AddressCity");
            DropColumn("dbo.AspNetUsers", "AddressStreet");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
            RenameIndex(table: "dbo.Boats", name: "IX_CreatedBy_Id", newName: "IX_AspNetUser_Id");
            RenameColumn(table: "dbo.Boats", name: "CreatedBy_Id", newName: "AspNetUser_Id");
        }
    }
}
