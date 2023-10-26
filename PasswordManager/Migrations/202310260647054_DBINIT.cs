namespace PasswordManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBINIT : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Passwords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PasswordsFor = c.String(),
                        Passwords = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Passwords", "UserId", "dbo.Users");
            DropIndex("dbo.Passwords", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.Passwords");
        }
    }
}
