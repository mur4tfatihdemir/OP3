namespace hotelf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v21 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ILs", newName: "Iller");
            AlterColumn("dbo.odas", "ucret", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.odas", "ucret", c => c.String());
            RenameTable(name: "dbo.Iller", newName: "ILs");
        }
    }
}
