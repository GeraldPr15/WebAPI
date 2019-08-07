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

        public DbSet<SistemaDePago> SistemaDePago { get; set; }
    }
}
