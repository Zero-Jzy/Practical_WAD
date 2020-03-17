﻿namespace Practical_WAD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValidateEmployee : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "EmployeeName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "EmployeeName", c => c.String());
        }
    }
}
