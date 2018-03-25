using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Models.Domain;

namespace Models
{
    public class ParroquiaDbContext : DbContext
    {
        public ParroquiaDbContext(DbContextOptions<ParroquiaDbContext> options)
            : base(options)
        {}

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Municipio> Municipio { get; set; }
        public DbSet<Bautismo> Bautismo { get; set; }
        public DbSet<Sacerdote> Sacerdote { get; set; }
        public DbSet<PuestoSacerdote> PuestoSacerdote { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);            
        //}
    }
}
