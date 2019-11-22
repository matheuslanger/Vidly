namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BirthDate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customer SET BirthDate = 1994/05/25 WHERE Id = 1");
            Sql("UPDATE Customer SET BirthDate = 2005/01/02 WHERE Id = 3");
            Sql("UPDATE Customer SET BirthDate = 1990/07/07 WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}