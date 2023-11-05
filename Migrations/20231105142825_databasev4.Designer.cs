﻿// <auto-generated />
using System;
using Examen_final_DW.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Examen_final_DW.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20231105142825_databasev4")]
    partial class databasev4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Examen_final_DW.Models.DetalleExpediente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("idEnfermedades")
                        .HasColumnType("int");

                    b.Property<int>("idEspecialesta")
                        .HasColumnType("int");

                    b.Property<int?>("idExpedientes")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Detalles");
                });

            modelBuilder.Entity("Examen_final_DW.Models.Expediente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("createdDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<int?>("detalleExpedienteId")
                        .HasColumnType("int");

                    b.Property<string>("fechaExpediente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idEnfermedad")
                        .HasColumnType("int");

                    b.Property<int>("idPaciente")
                        .HasColumnType("int");

                    b.Property<int?>("idexpediente")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("detalleExpedienteId");

                    b.ToTable("Expedientes");
                });

            modelBuilder.Entity("Examen_final_DW.Models.Expediente", b =>
                {
                    b.HasOne("Examen_final_DW.Models.DetalleExpediente", "detalleExpediente")
                        .WithMany("expediente")
                        .HasForeignKey("detalleExpedienteId");

                    b.Navigation("detalleExpediente");
                });

            modelBuilder.Entity("Examen_final_DW.Models.DetalleExpediente", b =>
                {
                    b.Navigation("expediente");
                });
#pragma warning restore 612, 618
        }
    }
}