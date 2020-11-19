using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace PaginaCine.Models
{
    public class CinematronicDBConnection:DbContext
    {
        public CinematronicDBConnection():base("cinedb")
        {

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<Cine> Cines { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}