namespace ContaWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContaCorrentes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Agencia = c.Int(nullable: false),
                        NumeroConta = c.Int(nullable: false),
                        Saldo = c.Double(nullable: false),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ContaCorrentes");
        }
    }
}
