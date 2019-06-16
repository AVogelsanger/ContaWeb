namespace ContaWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ContaCorrentes", "Movimentacao", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ContaCorrentes", "Movimentacao");
        }
    }
}
