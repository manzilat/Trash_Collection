namespace Trash_collection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedprpertiesinclendermoel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Calenders", "PickUpDay", c => c.DateTime(nullable: false));
            AddColumn("dbo.Calenders", "Bill", c => c.String());
            AddColumn("dbo.Calenders", "RegularPickupActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Calenders", "RegularPickupDayOfWeek", c => c.Int(nullable: false));
            AddColumn("dbo.Calenders", "RegularPickupStartDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Calenders", "RegularPickupEndDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Calenders", "RegularPickupPrice", c => c.Double(nullable: false));
            AddColumn("dbo.Calenders", "Calender_Id", c => c.Int());
            CreateIndex("dbo.Calenders", "Calender_Id");
            AddForeignKey("dbo.Calenders", "Calender_Id", "dbo.Calenders", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Calenders", "Calender_Id", "dbo.Calenders");
            DropIndex("dbo.Calenders", new[] { "Calender_Id" });
            DropColumn("dbo.Calenders", "Calender_Id");
            DropColumn("dbo.Calenders", "RegularPickupPrice");
            DropColumn("dbo.Calenders", "RegularPickupEndDate");
            DropColumn("dbo.Calenders", "RegularPickupStartDate");
            DropColumn("dbo.Calenders", "RegularPickupDayOfWeek");
            DropColumn("dbo.Calenders", "RegularPickupActive");
            DropColumn("dbo.Calenders", "Bill");
            DropColumn("dbo.Calenders", "PickUpDay");
        }
    }
}
