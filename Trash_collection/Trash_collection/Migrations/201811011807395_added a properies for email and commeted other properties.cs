namespace Trash_collection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedaproperiesforemailandcommetedotherproperties : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CustomerCalenders", "Customer_ID", "dbo.Customers");
            DropForeignKey("dbo.CustomerCalenders", "Calender_Id", "dbo.Calenders");
            DropIndex("dbo.CustomerCalenders", new[] { "Customer_ID" });
            DropIndex("dbo.CustomerCalenders", new[] { "Calender_Id" });
            AddColumn("dbo.Customers", "Calender_Id", c => c.Int());
            CreateIndex("dbo.Customers", "Calender_Id");
            AddForeignKey("dbo.Customers", "Calender_Id", "dbo.Calenders", "Id");
            DropColumn("dbo.Customers", "VacationPickupPause");
            DropColumn("dbo.Customers", "VacationStart");
            DropColumn("dbo.Customers", "VacationEnd");
            DropColumn("dbo.Customers", "PickUpDay");
            DropColumn("dbo.Customers", "SpecialPickupActive");
            DropColumn("dbo.Customers", "SpecialPickupDayOfWeek");
            DropColumn("dbo.Customers", "SpecialPickupStart");
            DropColumn("dbo.Customers", "SpecialPickupEnd");
            DropColumn("dbo.Customers", "SpecialPickupPrice");
            DropTable("dbo.CustomerCalenders");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CustomerCalenders",
                c => new
                    {
                        Customer_ID = c.Int(nullable: false),
                        Calender_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Customer_ID, t.Calender_Id });
            
            AddColumn("dbo.Customers", "SpecialPickupPrice", c => c.Double(nullable: false));
            AddColumn("dbo.Customers", "SpecialPickupEnd", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "SpecialPickupStart", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "SpecialPickupDayOfWeek", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "SpecialPickupActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "PickUpDay", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "VacationEnd", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "VacationStart", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "VacationPickupPause", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.Customers", "Calender_Id", "dbo.Calenders");
            DropIndex("dbo.Customers", new[] { "Calender_Id" });
            DropColumn("dbo.Customers", "Calender_Id");
            CreateIndex("dbo.CustomerCalenders", "Calender_Id");
            CreateIndex("dbo.CustomerCalenders", "Customer_ID");
            AddForeignKey("dbo.CustomerCalenders", "Calender_Id", "dbo.Calenders", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CustomerCalenders", "Customer_ID", "dbo.Customers", "ID", cascadeDelete: true);
        }
    }
}
