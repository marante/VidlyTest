namespace VidlyUdemyTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteredMovieModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "GenreId", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Movies", "GenreId");
            DropColumn("dbo.Movies", "Genre");
        }
        
        public override void Down()
        {
        }
    }
}
