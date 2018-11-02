namespace Trash_collection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "Calender_Id", "dbo.Calenders");
            DropIndex("dbo.Customers", new[] { "Calender_Id" });
            CreateTable(
                "dbo.CustomerCalenders",
                c => new
                    {
                        Customer_Id = c.Int(nullable: false),
                        Calender_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Customer_Id, t.Calender_Id })
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .ForeignKey("dbo.Calenders", t => t.Calender_Id, cascadeDelete: true)
                .Index(t => t.Customer_Id)
                .Index(t => t.Calender_Id);
            
            AddColumn("dbo.Customers", "StreetAddress", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "ZipCode", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "PickUpDay", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "state", c => c.String(nullable: false));
            DropColumn("dbo.Customers", "Address");
            DropColumn("dbo.Customers", "Zip");
            DropColumn("dbo.Customers", "PhoneNumber");
            DropColumn("dbo.Customers", "Calender_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Calender_Id", c => c.Int());
            AddColumn("dbo.Customers", "PhoneNumber", c => c.String());
            AddColumn("dbo.Customers", "Zip", c => c.String());
            AddColumn("dbo.Customers", "Address", c => c.String());
            DropForeignKey("dbo.CustomerCalenders", "Calender_Id", "dbo.Calenders");
            DropForeignKey("dbo.CustomerCalenders", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.CustomerCalenders", new[] { "Calender_Id" });
            DropIndex("dbo.CustomerCalenders", new[] { "Customer_Id" });
            AlterColumn("dbo.Customers", "state", c => c.String());
            AlterColumn("dbo.Customers", "City", c => c.String());
            AlterColumn("dbo.Customers", "LastName", c => c.String());
            AlterColumn("dbo.Customers", "FirstName", c => c.String());
            DropColumn("dbo.Customers", "PickUpDay");
            DropColumn("dbo.Customers", "ZipCode");
            DropColumn("dbo.Customers", "StreetAddress");
            DropTable("dbo.CustomerCalenders");
            CreateIndex("dbo.Customers", "Calender_Id");
            AddForeignKey("dbo.Customers", "Calender_Id", "dbo.Calenders", "Id");
        }
    }
}
