namespace Trash_collection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class madesomechangesinthecustomercontroller : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "RegularPickupActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "RegularPickupDayOfWeek", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "RegularPickupStartDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "RegularPickupEndDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "RegularPickupPrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "RegularPickupPrice");
            DropColumn("dbo.Customers", "RegularPickupEndDate");
            DropColumn("dbo.Customers", "RegularPickupStartDate");
            DropColumn("dbo.Customers", "RegularPickupDayOfWeek");
            DropColumn("dbo.Customers", "RegularPickupActive");
        }
    }
}
