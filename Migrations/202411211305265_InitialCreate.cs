namespace PruebaTecnica_PasajeInteligente.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Codigo = c.Int(nullable: false),
                        Direccion = c.String(),
                        Telefono = c.String(),
                        Ciudad = c.String(),
                        Departamento = c.String(),
                        Pais = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaActualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Empresas");
        }
    }
}
