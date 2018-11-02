namespace Trash_collection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.CustomerCalenders", new[] { "Customer_ID" });
            CreateIndex("dbo.CustomerCalenders", "Customer_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.CustomerCalenders", new[] { "Customer_Id" });
            CreateIndex("dbo.CustomerCalenders", "Customer_ID");
        }
    }
}
