namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredMovieDates : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Released", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "Added", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Added", c => c.DateTime());
            AlterColumn("dbo.Movies", "Released", c => c.DateTime());
        }
    }
}
