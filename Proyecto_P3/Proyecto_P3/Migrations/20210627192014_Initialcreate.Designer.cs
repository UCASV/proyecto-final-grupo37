﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parcial02.Context;

namespace Proyecto_P3.Migrations
{
    [DbContext(typeof(Parcial02Context))]
    [Migration("20210627192014_Initialcreate")]
    partial class Initialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Proyecto_P3.Entitys.Ciudadanos.Ciudadano", b =>
                {
                    b.Property<string>("Dui")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cellphone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direction")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Dui");

                    b.ToTable("Ciudadanos");
                });
#pragma warning restore 612, 618
        }
    }
}
