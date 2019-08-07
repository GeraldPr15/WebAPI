using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    public class SistemaDePagoContext : DbContext
    {
        public SistemaDePagoContext(DbContextOptions<SistemaDePagoContext> options)
            : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Write Fluent API configurations here

            modelBuilder.Entity<SistemaDePago>()
                .HasKey(e => e.Pago_ID);

            modelBuilder.Entity<SistemaDePago>()
                .Property(p => p.Nombre_Tarjeta)
                .HasColumnType("nvarchar(100)")
                .IsRequired();

            modelBuilder.Entity<SistemaDePago>()
                .Property(p => p.Numero_Tajerta)
                .HasColumnType("varchar(16)")
                .IsRequired();

            modelBuilder.Entity<SistemaDePago>()
                .Property(p => p.Dia_Expiracion)
                .HasColumnType("varchar(5)")
                .IsRequired();

            modelBuilder.Entity<SistemaDePago>()
                .Property(p => p.CVV)
                .HasColumnType("varchar(3)")
                .IsRequired();
        }
        public DbSet<SistemaDePago> SistemaDePago { get; set; }
    }
}
