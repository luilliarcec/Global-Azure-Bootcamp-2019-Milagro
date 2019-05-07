namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Demoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 75),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Descripcion, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Demoes", new[] { "Descripcion" });
            DropTable("dbo.Demoes");
        }
    }
}
