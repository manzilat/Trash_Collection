namespace Trash_collection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class madefewchangesincustomermodelandaddedpropertyforphonenumbers : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.CustomerCalenders", new[] { "Customer_Id" });
            AddColumn("dbo.Customers", "Address", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "Zip", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "PhoneNumber", c => c.String(nullable: false));
            CreateIndex("dbo.CustomerCalenders", "Customer_ID");
            DropColumn("dbo.Customers", "StreetAddress");
            DropColumn("dbo.Customers", "ZipCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "ZipCode", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "StreetAddress", c => c.String(nullable: false));
            DropIndex("dbo.CustomerCalenders", new[] { "Customer_ID" });
            DropColumn("dbo.Customers", "PhoneNumber");
            DropColumn("dbo.Customers", "Zip");
            DropColumn("dbo.Customers", "Address");
            CreateIndex("dbo.CustomerCalenders", "Customer_Id");
        }
    }
}
