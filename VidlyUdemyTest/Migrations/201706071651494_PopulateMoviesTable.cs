namespace VidlyUdemyTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Shrek', 'Comedy', 2007-01-02, 2017-06-07, 5)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Terminator', 'Action', 1998-02-05, 2017-06-07, 3)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Lord of the Rings', 'Legendary', 2001-05-06, 2017-06-07, 2)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('John Wick 2', 'Thriller', 2017-03-05, 2017-06-07, 1)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('CSGO the Movie', 'Cyka Blyat', 2017-05-05, 2017-06-07, 13)");
        }
        
        public override void Down()
        {
        }
    }
}
