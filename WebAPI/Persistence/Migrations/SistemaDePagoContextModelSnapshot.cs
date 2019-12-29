﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(SistemaDePagoContext))]
    partial class SistemaDePagoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.SistemaDePago", b =>
                {
                    b.Property<int>("Pago_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CVV")
                        .IsRequired()
                        .HasColumnType("varchar(3)");

                    b.Property<string>("Dia_Expiracion")
                        .IsRequired()
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Nombre_Tarjeta")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Numero_Tajerta")
                        .IsRequired()
                        .HasColumnType("varchar(16)");

                    b.HasKey("Pago_ID");

                    b.ToTable("SistemaDePago");
                });
#pragma warning restore 612, 618
        }
    }
}