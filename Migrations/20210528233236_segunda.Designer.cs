﻿// <auto-generated />
using Clase7;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Clase7.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20210528233236_segunda")]
    partial class segunda
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Clase7.Usuario", b =>
                {
                    b.Property<int>("num_usr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("bloqueado")
                        .HasColumnType("bit");

                    b.Property<int>("dni")
                        .HasColumnType("int");

                    b.Property<bool>("esADM")
                        .HasColumnType("bit");

                    b.Property<string>("mail")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("nombre")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("password")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("segundo_nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("num_usr");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}