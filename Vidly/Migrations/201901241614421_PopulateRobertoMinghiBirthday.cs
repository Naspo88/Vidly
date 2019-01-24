namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateRobertoMinghiBirthday : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday = '1988-10-29' WHERE Name = 'Roberto Minghi'");
        }
        
        public override void Down()
        {
        }
    }
}
