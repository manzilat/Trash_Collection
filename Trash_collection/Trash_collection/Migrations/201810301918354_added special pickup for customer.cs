namespace Trash_collection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedspecialpickupforcustomer : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "Calender_Id", "dbo.Calenders");
            DropIndex("dbo.Customers", new[] { "Calender_Id" });
            CreateTable(
                "dbo.CustomerCalenders",
                c => new
                    {
                        Customer_ID = c.Int(nullable: false),
                        Calender_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Customer_ID, t.Calender_Id })
                .ForeignKey("dbo.Customers", t => t.Customer_ID, cascadeDelete: true)
                .ForeignKey("dbo.Calenders", t => t.Calender_Id, cascadeDelete: true)
                .Index(t => t.Customer_ID)
                .Index(t => t.Calender_Id);
            
            AddColumn("dbo.Customers", "PickUpDay", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "Email", c => c.String(maxLength: 128));
            AddColumn("dbo.Customers", "Bill", c => c.String());
            AddColumn("dbo.Employees", "SpecialPickupActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Employees", "SpecialPickupDayOfWeek", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "SpecialPickupStart", c => c.DateTime(nullable: false));
            AddColumn("dbo.Employees", "SpecialPickupEnd", c => c.DateTime(nullable: false));
            AddColumn("dbo.Employees", "SpecialPickupPrice", c => c.Double(nullable: false));
            AddColumn("dbo.Employees", "VacationPickupPause", c => c.Boolean(nullable: false));
            AddColumn("dbo.Employees", "VacationStart", c => c.DateTime(nullable: false));
            AddColumn("dbo.Employees", "VacationEnd", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Customers", "Email");
            AddForeignKey("dbo.Customers", "Email", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.Customers", "VacationActivePickupPaused");
            DropColumn("dbo.Customers", "VacationStart");
            DropColumn("dbo.Customers", "VacationEnd");
            DropColumn("dbo.Customers", "RegularPickupActive");
            DropColumn("dbo.Customers", "RegularPickupDayOfWeek");
            DropColumn("dbo.Customers", "RegularPickupStartDate");
            DropColumn("dbo.Customers", "RegularPickupEndDate");
            DropColumn("dbo.Customers", "RegularPickupPrice");
            DropColumn("dbo.Customers", "Calender_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Calender_Id", c => c.Int());
            AddColumn("dbo.Customers", "RegularPickupPrice", c => c.Double(nullable: false));
            AddColumn("dbo.Customers", "RegularPickupEndDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "RegularPickupStartDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "RegularPickupDayOfWeek", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "RegularPickupActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "VacationEnd", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "VacationStart", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "VacationActivePickupPaused", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.CustomerCalenders", "Calender_Id", "dbo.Calenders");
            DropForeignKey("dbo.CustomerCalenders", "Customer_ID", "dbo.Customers");
            DropForeignKey("dbo.Customers", "Email", "dbo.AspNetUsers");
            DropIndex("dbo.CustomerCalenders", new[] { "Calender_Id" });
            DropIndex("dbo.CustomerCalenders", new[] { "Customer_ID" });
            DropIndex("dbo.Customers", new[] { "Email" });
            DropColumn("dbo.Employees", "VacationEnd");
            DropColumn("dbo.Employees", "VacationStart");
            DropColumn("dbo.Employees", "VacationPickupPause");
            DropColumn("dbo.Employees", "SpecialPickupPrice");
            DropColumn("dbo.Employees", "SpecialPickupEnd");
            DropColumn("dbo.Employees", "SpecialPickupStart");
            DropColumn("dbo.Employees", "SpecialPickupDayOfWeek");
            DropColumn("dbo.Employees", "SpecialPickupActive");
            DropColumn("dbo.Customers", "Bill");
            DropColumn("dbo.Customers", "Email");
            DropColumn("dbo.Customers", "PickUpDay");
            DropTable("dbo.CustomerCalenders");
            CreateIndex("dbo.Customers", "Calender_Id");
            AddForeignKey("dbo.Customers", "Calender_Id", "dbo.Calenders", "Id");
        }
    }
}
