namespace udemy1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populatecourse : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Users(name,password,isadmin) values ('Shaik','Shaik@143',1)");
        }
        
        public override void Down()
        {
        }
    }
}
