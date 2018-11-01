namespace Trash_collection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "VacationPickupPause", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "VacationStart", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "VacationEnd", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "SpecialPickupActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "SpecialPickupDayOfWeek", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "SpecialPickupStart", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "SpecialPickupEnd", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "SpecialPickupPrice", c => c.Double(nullable: false));
            DropColumn("dbo.Employees", "SpecialPickupActive");
            DropColumn("dbo.Employees", "SpecialPickupDayOfWeek");
            DropColumn("dbo.Employees", "SpecialPickupStart");
            DropColumn("dbo.Employees", "SpecialPickupEnd");
            DropColumn("dbo.Employees", "SpecialPickupPrice");
            DropColumn("dbo.Employees", "VacationPickupPause");
            DropColumn("dbo.Employees", "VacationStart");
            DropColumn("dbo.Employees", "VacationEnd");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "VacationEnd", c => c.DateTime(nullable: false));
            AddColumn("dbo.Employees", "VacationStart", c => c.DateTime(nullable: false));
            AddColumn("dbo.Employees", "VacationPickupPause", c => c.Boolean(nullable: false));
            AddColumn("dbo.Employees", "SpecialPickupPrice", c => c.Double(nullable: false));
            AddColumn("dbo.Employees", "SpecialPickupEnd", c => c.DateTime(nullable: false));
            AddColumn("dbo.Employees", "SpecialPickupStart", c => c.DateTime(nullable: false));
            AddColumn("dbo.Employees", "SpecialPickupDayOfWeek", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "SpecialPickupActive", c => c.Boolean(nullable: false));
            DropColumn("dbo.Customers", "SpecialPickupPrice");
            DropColumn("dbo.Customers", "SpecialPickupEnd");
            DropColumn("dbo.Customers", "SpecialPickupStart");
            DropColumn("dbo.Customers", "SpecialPickupDayOfWeek");
            DropColumn("dbo.Customers", "SpecialPickupActive");
            DropColumn("dbo.Customers", "VacationEnd");
            DropColumn("dbo.Customers", "VacationStart");
            DropColumn("dbo.Customers", "VacationPickupPause");
        }
    }
}
