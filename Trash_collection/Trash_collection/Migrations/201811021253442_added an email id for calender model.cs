namespace Trash_collection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedanemailidforcalendermodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Calenders", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Calenders", "Email");
        }
    }
}
