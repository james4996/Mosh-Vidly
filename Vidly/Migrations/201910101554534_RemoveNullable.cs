namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "AddedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "AddedDate", c => c.DateTime());
        }
    }
}
