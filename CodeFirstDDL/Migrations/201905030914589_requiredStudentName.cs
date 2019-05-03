namespace CodeFirstDDL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class requiredStudentName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE [dbo].[Students] SET StudentName = 'No Name' WHERE StudentName IS NULL");
            AlterColumn("dbo.Students", "StudentName", c => c.String(nullable: false, defaultValue: "" ));
        }
        
        public override void Down()
        {
       
            AlterColumn("dbo.Students", "StudentName", c => c.String());
        }
    }
}
