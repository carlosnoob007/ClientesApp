﻿// <auto-generated />
using System;
using ClientesApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClientesApp.Migrations
{
    [DbContext(typeof(ClientesBDContext))]
    [Migration("20230627010007_initialMigration")]
    partial class initialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClientesApp.Models.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.HasKey("id");

                    b.ToTable("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}
