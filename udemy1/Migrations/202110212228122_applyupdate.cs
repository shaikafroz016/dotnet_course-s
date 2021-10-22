namespace udemy1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class applyupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "name", c => c.String(nullable: false));
            AlterColumn("dbo.Courses", "catg", c => c.String(nullable: false));
            AlterColumn("dbo.Courses", "Discription", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "name", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "password", c => c.String());
            AlterColumn("dbo.Users", "name", c => c.String());
            AlterColumn("dbo.Courses", "Discription", c => c.String());
            AlterColumn("dbo.Courses", "catg", c => c.String());
            AlterColumn("dbo.Courses", "name", c => c.String());
        }
    }
}
