namespace Trash_collection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedaforeignkey : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Calenders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Days = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "Calender_Id", c => c.Int());
            CreateIndex("dbo.Customers", "Calender_Id");
            AddForeignKey("dbo.Customers", "Calender_Id", "dbo.Calenders", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "Calender_Id", "dbo.Calenders");
            DropIndex("dbo.Customers", new[] { "Calender_Id" });
            DropColumn("dbo.Customers", "Calender_Id");
            DropTable("dbo.Calenders");
        }
    }
}
