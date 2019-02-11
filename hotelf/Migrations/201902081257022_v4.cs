namespace hotelf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Iller", newName: "Illerb");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Illerb", newName: "Iller");
        }
    }
}
