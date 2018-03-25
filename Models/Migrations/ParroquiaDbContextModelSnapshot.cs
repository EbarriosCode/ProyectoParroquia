﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Models;
using System;

namespace Models.Migrations
{
    [DbContext(typeof(ParroquiaDbContext))]
    partial class ParroquiaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.Domain.Bautismo", b =>
                {
                    b.Property<int>("BautismoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DepartamentoId");

                    b.Property<string>("Direccion");

                    b.Property<DateTime>("FechaBautismo");

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<string>("Folio");

                    b.Property<string>("Libro");

                    b.Property<string>("Madrina");

                    b.Property<int?>("MunicipioId");

                    b.Property<string>("NombreBautizado");

                    b.Property<string>("Observaciones");

                    b.Property<string>("PadresBautizado");

                    b.Property<string>("Padrino");

                    b.Property<string>("Partida");

                    b.Property<int>("SacerdoteId");

                    b.HasKey("BautismoId");

                    b.HasIndex("DepartamentoId");

                    b.HasIndex("MunicipioId");

                    b.HasIndex("SacerdoteId");

                    b.ToTable("Bautismo");
                });

            modelBuilder.Entity("Models.Domain.Departamento", b =>
                {
                    b.Property<int>("DepartamentoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NombreDepartamento");

                    b.HasKey("DepartamentoId");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("Models.Domain.Municipio", b =>
                {
                    b.Property<int>("MunicipioId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DepartamentoId");

                    b.Property<string>("NombreMunicipio");

                    b.HasKey("MunicipioId");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Municipio");
                });

            modelBuilder.Entity("Models.Domain.PuestoSacerdote", b =>
                {
                    b.Property<int>("PuestoSacerdoteId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NombrePuesto");

                    b.HasKey("PuestoSacerdoteId");

                    b.ToTable("PuestoSacerdote");
                });

            modelBuilder.Entity("Models.Domain.Sacerdote", b =>
                {
                    b.Property<int>("SacerdoteId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Activo");

                    b.Property<string>("Apellidos");

                    b.Property<DateTime>("FechaLlegadaParroquia");

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<DateTime>("FechaRetiradaParroquia");

                    b.Property<string>("Nombres");

                    b.Property<int>("PuestoSacerdoteId");

                    b.HasKey("SacerdoteId");

                    b.HasIndex("PuestoSacerdoteId");

                    b.ToTable("Sacerdote");
                });

            modelBuilder.Entity("Models.Domain.Bautismo", b =>
                {
                    b.HasOne("Models.Domain.Departamento", "Departamento")
                        .WithMany("Bautismo")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Models.Domain.Municipio", "Municipio")
                        .WithMany("Bautismo")
                        .HasForeignKey("MunicipioId");

                    b.HasOne("Models.Domain.Sacerdote", "Sacerdote")
                        .WithMany("Bautismo")
                        .HasForeignKey("SacerdoteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Models.Domain.Municipio", b =>
                {
                    b.HasOne("Models.Domain.Departamento", "Departamento")
                        .WithMany("Municipio")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Models.Domain.Sacerdote", b =>
                {
                    b.HasOne("Models.Domain.PuestoSacerdote", "PuestoSacerdote")
                        .WithMany("Sacerdote")
                        .HasForeignKey("PuestoSacerdoteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
