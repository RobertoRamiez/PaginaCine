﻿namespace PaginaCine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class startProject : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        Hora = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cines");
        }
    }
}
