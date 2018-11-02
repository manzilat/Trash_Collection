namespace Trash_collection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class doingatestandcommentingotherproperties : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CustomerCalenders", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.CustomerCalenders", "Calender_Id", "dbo.Calenders");
            DropForeignKey("dbo.Customers", "Email", "dbo.AspNetUsers");
            DropIndex("dbo.Customers", new[] { "Email" });
            DropIndex("dbo.CustomerCalenders", new[] { "Customer_Id" });
            DropIndex("dbo.CustomerCalenders", new[] { "Calender_Id" });
            AddColumn("dbo.Customers", "ApplicationUsers_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Customers", "Calender_Id", c => c.Int());
            AlterColumn("dbo.Customers", "Email", c => c.String());
            CreateIndex("dbo.Customers", "ApplicationUsers_Id");
            CreateIndex("dbo.Customers", "Calender_Id");
            AddForeignKey("dbo.Customers", "Calender_Id", "dbo.Calenders", "Id");
            AddForeignKey("dbo.Customers", "ApplicationUsers_Id", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.Customers", "PickUpDay");
            DropColumn("dbo.Customers", "Bill");
            DropColumn("dbo.Customers", "RegularPickupActive");
            DropColumn("dbo.Customers", "RegularPickupDayOfWeek");
            DropColumn("dbo.Customers", "RegularPickupStartDate");
            DropColumn("dbo.Customers", "RegularPickupEndDate");
            DropColumn("dbo.Customers", "RegularPickupPrice");
            DropTable("dbo.CustomerCalenders");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CustomerCalenders",
                c => new
                    {
                        Customer_Id = c.Int(nullable: false),
                        Calender_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Customer_Id, t.Calender_Id });
            
            AddColumn("dbo.Customers", "RegularPickupPrice", c => c.Double(nullable: false));
            AddColumn("dbo.Customers", "RegularPickupEndDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "RegularPickupStartDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "RegularPickupDayOfWeek", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "RegularPickupActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "Bill", c => c.String());
            AddColumn("dbo.Customers", "PickUpDay", c => c.DateTime(nullable: false));
            DropForeignKey("dbo.Customers", "ApplicationUsers_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Customers", "Calender_Id", "dbo.Calenders");
            DropIndex("dbo.Customers", new[] { "Calender_Id" });
            DropIndex("dbo.Customers", new[] { "ApplicationUsers_Id" });
            AlterColumn("dbo.Customers", "Email", c => c.String(maxLength: 128));
            DropColumn("dbo.Customers", "Calender_Id");
            DropColumn("dbo.Customers", "ApplicationUsers_Id");
            CreateIndex("dbo.CustomerCalenders", "Calender_Id");
            CreateIndex("dbo.CustomerCalenders", "Customer_Id");
            CreateIndex("dbo.Customers", "Email");
            AddForeignKey("dbo.Customers", "Email", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.CustomerCalenders", "Calender_Id", "dbo.Calenders", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CustomerCalenders", "Customer_Id", "dbo.Customers", "Id", cascadeDelete: true);
        }
    }
}
